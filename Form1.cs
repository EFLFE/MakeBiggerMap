using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using CodeImp.DoomBuilder.Geometry;
using CodeImp.DoomBuilder.Map;

namespace CodeImp.DoomBuilder.MakeBiggerMap
{
    public partial class MakeBiggerMapForm : Form
    {
        private const string V = " V4";

        private static class Saves
        {
            public static bool FirstStart = true;

            public static string idsText;
            public static int cloneActors;
            public static int exVertix;
            public static int exHoriz;
            //public static bool noExEqualsSector;
            //public static bool addMissingTexture;

            public static void Reset()
            {
                idsText = string.Empty;
                cloneActors = 0;
                exVertix = 0;
                exHoriz = 0;
                //noExEqualsSector = false;
                //addMissingTexture = false;
            }
        }

        private int[] SkipId = { 0 };

        private IdList idListForm;

        public MakeBiggerMapForm()
        {
            InitializeComponent( );

            Text += V + " by HarkBack";

            idListForm = new IdList( );

            if (Saves.FirstStart)
            {
                Saves.FirstStart = false;
                Saves.Reset( );
            }
            else
            {
                // load
                //noExEqualsSector.Checked = Saves.noExEqualsSector;
                //addMissingTexture.Checked = Saves.addMissingTexture;
                ids.Text = Saves.idsText;

                switch (Saves.cloneActors)
                {
                case 0:
                    noCloneActors.Checked = true;
                    break;
                case 1:
                    clone2X2.Checked = true;
                    break;
                case 2:
                    clone3X3.Checked = true;
                    break;
                }

                switch (Saves.exVertix)
                {
                case 0:
                    exVertixNone.Checked = true;
                    break;
                case 1:
                    exVertix2.Checked = true;
                    break;
                case 2:
                    exVertix3.Checked = true;
                    break;
                case 3:
                    exVertix4.Checked = true;
                    break;
                }

                switch (Saves.exHoriz)
                {
                case 0:
                    exHorizNone.Checked = true;
                    break;
                case 1:
                    exHoriz2.Checked = true;
                    break;
                case 2:
                    exHoriz3.Checked = true;
                    break;
                case 3:
                    exHoriz4.Checked = true;
                    break;
                }
            }
        }

        /// <returns> Текст, сопоставленный с этим элементом управления. </returns>
        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void Make()
        {
            General.Map.UndoRedo.CreateUndo( "Make Bigger Map." );

            RaizeSectors( );
            ExsizeVertices( );
            RecloneThings( );

            General.Map.ThingsFilter.Update( );
            General.Map.IsChanged = true;
            General.Map.Map.Update( true, true );
            General.Interface.RedrawDisplay( );

            Close( );
        }

        private void RaizeSectors()
        {
            if (exHorizNone.Checked)
                return;

            int mnj = 4;

            if (exHoriz2.Checked)
                mnj = 2;
            else if (exHoriz3.Checked)
                mnj = 3;

            foreach (var sector in General.Map.Map.Sectors)
            {
                //if (sector.FloorHeight < 0)
                //    sector.FloorHeight += mnj * (sector.FloorHeight * -1);
                //else
                sector.FloorHeight *= mnj;

                //if (sector.CeilHeight < 0)
                //    sector.CeilHeight += mnj * (sector.CeilHeight * -1);
                //else
                sector.CeilHeight *= mnj;
            }

            //if (!addMissingTexture.Checked)
            //    return;
            //
            //foreach (var lines in General.Map.Map.Linedefs)
            //{
            //    if (!lines.IsFlagSet( "1" ))
            //    {
            //        // фикс отсуствия текстуры при поднятии потолка путём зазеркаливания текстуры
            //        if (lines.Front.LowTexture != lines.Front.HighTexture)
            //        {
            //            // front
            //            if (lines.Front.LowTexture == NO_TEXTURE)
            //                lines.Front.SetTextureLow( lines.Front.HighTexture );
            //            else
            //                lines.Front.SetTextureHigh( lines.Front.LowTexture );
            //
            //            // back
            //            if (lines.Back.LowTexture == NO_TEXTURE)
            //                lines.Back.SetTextureLow( lines.Front.HighTexture );
            //            else
            //                lines.Back.SetTextureHigh( lines.Front.LowTexture );
            //        }
            //    }
            //}

        }

        private void ExsizeVertices()
        {
            if (exVertixNone.Checked)
                return;

            var mnj = 4f;

            if (exVertix2.Checked)
                mnj = 2f;

            else if (exVertix3.Checked)
                mnj = 3f;

            foreach (var ver in General.Map.Map.Vertices)
            {
                ver.Move( ver.Position * mnj );
            }
        }

        private void RecloneThings()
        {
            if (exVertixNone.Checked)
                return;

            //var mnj = clone2X2.Checked ? 2f : 3f;
            var mnj = 4f;

            if (exVertix2.Checked)
                mnj = 2f;

            else if (exVertix3.Checked)
                mnj = 3f;

            var enumer = General.Map.Map.Things.GetEnumerator( );

            while (true)
            {
                if (!enumer.MoveNext( ) || enumer.Current == null)
                {
                    enumer.Reset( );
                    break;
                }

                // move instance
                enumer.Current.Move( enumer.Current.Position * mnj );

                if (noCloneActors.Checked || SkipId.Contains( enumer.Current.Type ))
                    continue;

                var startPos = enumer.Current.Position;
                var size = enumer.Current.Size * 2f;

                if (clone2X2.Checked || clone3X3.Checked)
                {
                    //    [+]
                    // [+][O][+]
                    //    [+]
                    var t1 = General.Map.Map.CreateThing( );
                    var t2 = General.Map.Map.CreateThing( );
                    var t3 = General.Map.Map.CreateThing( );
                    var t4 = General.Map.Map.CreateThing( );
                    enumer.Current.CopyPropertiesTo( t2 );
                    enumer.Current.CopyPropertiesTo( t1 );
                    enumer.Current.CopyPropertiesTo( t3 );
                    enumer.Current.CopyPropertiesTo( t4 );

                    t1.Move( startPos + new Vector3D( size, 0, 0 ) );
                    t2.Move( startPos + new Vector3D( -size, 0, 0 ) );
                    t3.Move( startPos + new Vector3D( 0, size, 0 ) );
                    t4.Move( startPos + new Vector3D( 0, -size, 0 ) );

                    t1.UpdateConfiguration( );
                    t2.UpdateConfiguration( );
                    t3.UpdateConfiguration( );
                    t4.UpdateConfiguration( );
                }
                if (clone3X3.Checked)
                {
                    // [+]   [+]
                    //    [O]
                    // [+]   [+]
                    var t1 = General.Map.Map.CreateThing( );
                    var t2 = General.Map.Map.CreateThing( );
                    var t3 = General.Map.Map.CreateThing( );
                    var t4 = General.Map.Map.CreateThing( );
                    enumer.Current.CopyPropertiesTo( t2 );
                    enumer.Current.CopyPropertiesTo( t1 );
                    enumer.Current.CopyPropertiesTo( t3 );
                    enumer.Current.CopyPropertiesTo( t4 );

                    t1.Move( startPos + new Vector3D( size, size, 0 ) );
                    t2.Move( startPos + new Vector3D( -size, -size, 0 ) );
                    t3.Move( startPos + new Vector3D( -size, size, 0 ) );
                    t4.Move( startPos + new Vector3D( size, -size, 0 ) );

                    t1.UpdateConfiguration( );
                    t2.UpdateConfiguration( );
                    t3.UpdateConfiguration( );
                    t4.UpdateConfiguration( );
                }
            }
        }

        // cancel
        private void button4_Click(object sender, EventArgs e)
        {
            Close( );
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Save( );
            base.OnClosing( e );
        }

        // чта? (справка)
        private void button2_Click_1(object sender, EventArgs e)
        {
            idListForm.Show( Owner );
        }

        private void Save()
        {
            //Saves.noExEqualsSector = noExEqualsSector.Checked;
            //Saves.addMissingTexture = addMissingTexture.Checked;
            Saves.idsText = ids.Text;

            if (noCloneActors.Checked)
                Saves.cloneActors = 0;
            else if (clone2X2.Checked)
                Saves.cloneActors = 1;
            else
                Saves.cloneActors = 2;

            if (exVertixNone.Checked)
                Saves.exVertix = 0;
            else if (exVertix2.Checked)
                Saves.exVertix = 1;
            else if (exVertix3.Checked)
                Saves.exVertix = 2;
            else
                Saves.exVertix = 3;

            if (exHorizNone.Checked)
                Saves.exHoriz = 0;
            else if (exHoriz2.Checked)
                Saves.exHoriz = 1;
            else if (exHoriz3.Checked)
                Saves.exHoriz = 2;
            else
                Saves.exHoriz = 3;
        }

        // check & make
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ids.Text.Length > 0)
            {
                try
                {
                    var idsTextSplit = ids.Text.Split( ' ' );
                    SkipId = new int[idsTextSplit.Length];
                    for (int i = 0; i < idsTextSplit.Length; i++)
                    {
                        SkipId[i] = int.Parse( idsTextSplit[i] );
                    }
                }
                catch
                {
                    ids.Text = string.Empty;
                    MessageBox.Show( Owner, "Список ID актёров нужно перечислять через пробел. Это поле можно оставить пустым." );
                    return;
                }
            }
            else
            {
                SkipId = new[] { 0 };
            }

            if (exVertixNone.Checked && exHorizNone.Checked && noCloneActors.Checked)
            {
                MessageBox.Show( Owner, "Так как бы нечего же расширять." );
                return;
            }

            Make( );
            Close( );
        }

        // reset
        private void button3_Click(object sender, EventArgs e)
        {
            ids.Text = string.Empty;
            noCloneActors.Checked = true;
            exVertixNone.Checked = true;
            exHorizNone.Checked = true;
            //noExEqualsSector.Checked = false;
            //addMissingTexture.Checked = false;
            Saves.Reset( );
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start( @"https://github.com/HarkBack/MakeBiggerMap" );
        }
    }
}
