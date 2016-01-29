namespace CodeImp.DoomBuilder.MakeBiggerMap
{
    partial class MakeBiggerMapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exVertix4 = new System.Windows.Forms.RadioButton();
            this.exVertix3 = new System.Windows.Forms.RadioButton();
            this.exVertix2 = new System.Windows.Forms.RadioButton();
            this.exVertixNone = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exHoriz4 = new System.Windows.Forms.RadioButton();
            this.exHoriz3 = new System.Windows.Forms.RadioButton();
            this.exHoriz2 = new System.Windows.Forms.RadioButton();
            this.exHorizNone = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.clone3X3 = new System.Windows.Forms.RadioButton();
            this.clone2X2 = new System.Windows.Forms.RadioButton();
            this.noCloneActors = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.ids = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Location = new System.Drawing.Point(388, 144);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(279, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Расширить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exVertix4);
            this.panel1.Controls.Add(this.exVertix3);
            this.panel1.Controls.Add(this.exVertix2);
            this.panel1.Controls.Add(this.exVertixNone);
            this.panel1.Location = new System.Drawing.Point(279, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 52);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Расширить по горизонтали:";
            // 
            // exVertix4
            // 
            this.exVertix4.AutoSize = true;
            this.exVertix4.Location = new System.Drawing.Point(195, 22);
            this.exVertix4.Name = "exVertix4";
            this.exVertix4.Size = new System.Drawing.Size(44, 22);
            this.exVertix4.TabIndex = 5;
            this.exVertix4.Text = "4X";
            this.exVertix4.UseVisualStyleBackColor = true;
            // 
            // exVertix3
            // 
            this.exVertix3.AutoSize = true;
            this.exVertix3.Location = new System.Drawing.Point(145, 22);
            this.exVertix3.Name = "exVertix3";
            this.exVertix3.Size = new System.Drawing.Size(44, 22);
            this.exVertix3.TabIndex = 5;
            this.exVertix3.Text = "3X";
            this.exVertix3.UseVisualStyleBackColor = true;
            // 
            // exVertix2
            // 
            this.exVertix2.AutoSize = true;
            this.exVertix2.Location = new System.Drawing.Point(95, 22);
            this.exVertix2.Name = "exVertix2";
            this.exVertix2.Size = new System.Drawing.Size(44, 22);
            this.exVertix2.TabIndex = 5;
            this.exVertix2.Text = "2X";
            this.exVertix2.UseVisualStyleBackColor = true;
            // 
            // exVertixNone
            // 
            this.exVertixNone.AutoSize = true;
            this.exVertixNone.Checked = true;
            this.exVertixNone.Location = new System.Drawing.Point(6, 22);
            this.exVertixNone.Name = "exVertixNone";
            this.exVertixNone.Size = new System.Drawing.Size(83, 22);
            this.exVertixNone.TabIndex = 5;
            this.exVertixNone.TabStop = true;
            this.exVertixNone.Text = "Не надо";
            this.exVertixNone.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.exHoriz4);
            this.panel2.Controls.Add(this.exHoriz3);
            this.panel2.Controls.Add(this.exHoriz2);
            this.panel2.Controls.Add(this.exHorizNone);
            this.panel2.Location = new System.Drawing.Point(279, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 52);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Расширить по вертикали:";
            // 
            // exHoriz4
            // 
            this.exHoriz4.AutoSize = true;
            this.exHoriz4.Location = new System.Drawing.Point(195, 22);
            this.exHoriz4.Name = "exHoriz4";
            this.exHoriz4.Size = new System.Drawing.Size(44, 22);
            this.exHoriz4.TabIndex = 5;
            this.exHoriz4.Text = "4X";
            this.exHoriz4.UseVisualStyleBackColor = true;
            // 
            // exHoriz3
            // 
            this.exHoriz3.AutoSize = true;
            this.exHoriz3.Location = new System.Drawing.Point(145, 22);
            this.exHoriz3.Name = "exHoriz3";
            this.exHoriz3.Size = new System.Drawing.Size(44, 22);
            this.exHoriz3.TabIndex = 5;
            this.exHoriz3.Text = "3X";
            this.exHoriz3.UseVisualStyleBackColor = true;
            // 
            // exHoriz2
            // 
            this.exHoriz2.AutoSize = true;
            this.exHoriz2.Location = new System.Drawing.Point(95, 22);
            this.exHoriz2.Name = "exHoriz2";
            this.exHoriz2.Size = new System.Drawing.Size(44, 22);
            this.exHoriz2.TabIndex = 5;
            this.exHoriz2.Text = "2X";
            this.exHoriz2.UseVisualStyleBackColor = true;
            // 
            // exHorizNone
            // 
            this.exHorizNone.AutoSize = true;
            this.exHorizNone.Checked = true;
            this.exHorizNone.Location = new System.Drawing.Point(6, 22);
            this.exHorizNone.Name = "exHorizNone";
            this.exHorizNone.Size = new System.Drawing.Size(83, 22);
            this.exHorizNone.TabIndex = 5;
            this.exHorizNone.TabStop = true;
            this.exHorizNone.Text = "Не надо";
            this.exHorizNone.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.clone3X3);
            this.panel3.Controls.Add(this.clone2X2);
            this.panel3.Controls.Add(this.noCloneActors);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(261, 52);
            this.panel3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Клонирование актёров:";
            // 
            // clone3X3
            // 
            this.clone3X3.AutoSize = true;
            this.clone3X3.Location = new System.Drawing.Point(153, 22);
            this.clone3X3.Name = "clone3X3";
            this.clone3X3.Size = new System.Drawing.Size(44, 22);
            this.clone3X3.TabIndex = 5;
            this.clone3X3.Text = "X8";
            this.clone3X3.UseVisualStyleBackColor = true;
            // 
            // clone2X2
            // 
            this.clone2X2.AutoSize = true;
            this.clone2X2.Location = new System.Drawing.Point(95, 22);
            this.clone2X2.Name = "clone2X2";
            this.clone2X2.Size = new System.Drawing.Size(44, 22);
            this.clone2X2.TabIndex = 5;
            this.clone2X2.Text = "X4";
            this.clone2X2.UseVisualStyleBackColor = true;
            // 
            // noCloneActors
            // 
            this.noCloneActors.AutoSize = true;
            this.noCloneActors.Checked = true;
            this.noCloneActors.Location = new System.Drawing.Point(6, 22);
            this.noCloneActors.Name = "noCloneActors";
            this.noCloneActors.Size = new System.Drawing.Size(83, 22);
            this.noCloneActors.TabIndex = 5;
            this.noCloneActors.TabStop = true;
            this.noCloneActors.Text = "Не надо";
            this.noCloneActors.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "Список ID актёров, которых не нужно клонировать:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.ids);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(12, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 138);
            this.panel4.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ids
            // 
            this.ids.Location = new System.Drawing.Point(3, 55);
            this.ids.Multiline = true;
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(255, 83);
            this.ids.TabIndex = 9;
            this.ids.Text = "1 2 3 4";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(388, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "Сброс";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(504, 192);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 18);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "GitHub source";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MakeBiggerMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 219);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MakeBiggerMapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeBiggerMap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton exVertix4;
        private System.Windows.Forms.RadioButton exVertix3;
        private System.Windows.Forms.RadioButton exVertix2;
        private System.Windows.Forms.RadioButton exVertixNone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton exHoriz4;
        private System.Windows.Forms.RadioButton exHoriz3;
        private System.Windows.Forms.RadioButton exHoriz2;
        private System.Windows.Forms.RadioButton exHorizNone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton clone3X3;
        private System.Windows.Forms.RadioButton clone2X2;
        private System.Windows.Forms.RadioButton noCloneActors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}