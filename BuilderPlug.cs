using System;
using System.Windows.Forms;
using CodeImp.DoomBuilder.Actions;
using CodeImp.DoomBuilder.Plugins;

namespace CodeImp.DoomBuilder.MakeBiggerMap
{
    public class BuilderPlug : Plug
    {
        // Static instance. We can't use a real static class, because BuilderPlug must
        // be instantiated by the core, so we keep a static reference. (this technique
        // should be familiar to object-oriented programmers)
        private static BuilderPlug me;

        // Static property to access the BuilderPlug
        public static BuilderPlug Me { get { return me; } }
        public override string Name { get { return "MakeBiggerMap"; } }
        public override int MinimumRevision { get { return 1546; } }

        private ToolStripButton tagrangebutton;

        // This event is called when the plugin is initialized
        public override void OnInitialize()
        {
            base.OnInitialize( );

            // Keep a static reference
            me = this;

            General.Actions.BindMethods( this );

            tagrangebutton = new ToolStripButton
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = Properties.Resources.ToolIco,
                ImageTransparentColor = System.Drawing.Color.Magenta,
                Name = "MakeBiggerMapButton",
                Size = new System.Drawing.Size(23, 22),
                Tag = "makebigger",
                Text = "MakeBiggerMap"
            };
            tagrangebutton.Click += InvokeTaggedAction;
            General.Interface.AddButton(tagrangebutton);
        }

        private void InvokeTaggedAction(object sender, EventArgs e)
        {
            General.Interface.InvokeTaggedAction(sender, e);
        }

        // This is called when the plugin is terminated
        public override void Dispose()
        {
            base.Dispose( );

            General.Actions.UnbindMethods( this );
        }

        [BeginAction( "makebigger" )]
        private void RangeTagSelection()
        {
            var f = new MakeBiggerMapForm( );
            f.ShowDialog( Form.ActiveForm );
            f.Dispose( );
        }
    }
}
