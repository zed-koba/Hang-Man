namespace HangMan
{
    partial class Levels
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTItle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pDragForm = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pbLevel5 = new System.Windows.Forms.PictureBox();
            this.pbLevel4 = new System.Windows.Forms.PictureBox();
            this.pbLevel3 = new System.Windows.Forms.PictureBox();
            this.pbLevel2 = new System.Windows.Forms.PictureBox();
            this.pbLevel1 = new System.Windows.Forms.PictureBox();
            this.pbMonster5 = new System.Windows.Forms.PictureBox();
            this.pbMonster4 = new System.Windows.Forms.PictureBox();
            this.pbMonster3 = new System.Windows.Forms.PictureBox();
            this.pbMonster2 = new System.Windows.Forms.PictureBox();
            this.pbMonster = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pDragForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTItle
            // 
            this.lblTItle.AutoSize = true;
            this.lblTItle.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTItle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTItle.Location = new System.Drawing.Point(514, 6);
            this.lblTItle.Name = "lblTItle";
            this.lblTItle.Size = new System.Drawing.Size(80, 18);
            this.lblTItle.TabIndex = 1;
            this.lblTItle.Text = "Hangman";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Location = new System.Drawing.Point(1068, -23);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 76);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pDragForm
            // 
            this.pDragForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.pDragForm.Controls.Add(this.lblTItle);
            this.pDragForm.Controls.Add(this.btnClose);
            this.pDragForm.Controls.Add(this.btnMinimize);
            this.pDragForm.Location = new System.Drawing.Point(0, 1);
            this.pDragForm.Name = "pDragForm";
            this.pDragForm.Size = new System.Drawing.Size(1130, 30);
            this.pDragForm.TabIndex = 4;
            this.pDragForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pDragForm_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(1098, -23);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 76);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbLevel5
            // 
            this.pbLevel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLevel5.Image = global::HangMan.Properties.Resources.level5incomplete;
            this.pbLevel5.Location = new System.Drawing.Point(597, 176);
            this.pbLevel5.Name = "pbLevel5";
            this.pbLevel5.Size = new System.Drawing.Size(60, 53);
            this.pbLevel5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLevel5.TabIndex = 5;
            this.pbLevel5.TabStop = false;
            this.pbLevel5.Click += new System.EventHandler(this.pbLevel5_Click);
            // 
            // pbLevel4
            // 
            this.pbLevel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLevel4.Image = global::HangMan.Properties.Resources.level4incomplete;
            this.pbLevel4.Location = new System.Drawing.Point(649, 318);
            this.pbLevel4.Name = "pbLevel4";
            this.pbLevel4.Size = new System.Drawing.Size(60, 53);
            this.pbLevel4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLevel4.TabIndex = 5;
            this.pbLevel4.TabStop = false;
            this.pbLevel4.Click += new System.EventHandler(this.pbLevel4_Click);
            // 
            // pbLevel3
            // 
            this.pbLevel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLevel3.Image = global::HangMan.Properties.Resources.level3incomplete;
            this.pbLevel3.Location = new System.Drawing.Point(517, 405);
            this.pbLevel3.Name = "pbLevel3";
            this.pbLevel3.Size = new System.Drawing.Size(60, 53);
            this.pbLevel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLevel3.TabIndex = 5;
            this.pbLevel3.TabStop = false;
            this.pbLevel3.Click += new System.EventHandler(this.pbLevel3_Click);
            // 
            // pbLevel2
            // 
            this.pbLevel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLevel2.Image = global::HangMan.Properties.Resources.level2incomplete;
            this.pbLevel2.Location = new System.Drawing.Point(436, 541);
            this.pbLevel2.Name = "pbLevel2";
            this.pbLevel2.Size = new System.Drawing.Size(60, 53);
            this.pbLevel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLevel2.TabIndex = 5;
            this.pbLevel2.TabStop = false;
            this.pbLevel2.Click += new System.EventHandler(this.pbLevel2_Click);
            // 
            // pbLevel1
            // 
            this.pbLevel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLevel1.Image = global::HangMan.Properties.Resources.level1incomplete;
            this.pbLevel1.Location = new System.Drawing.Point(469, 703);
            this.pbLevel1.Name = "pbLevel1";
            this.pbLevel1.Size = new System.Drawing.Size(60, 53);
            this.pbLevel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLevel1.TabIndex = 5;
            this.pbLevel1.TabStop = false;
            this.pbLevel1.Click += new System.EventHandler(this.pbLevel1_Click);
            // 
            // pbMonster5
            // 
            this.pbMonster5.Image = global::HangMan.Properties.Resources._0_Ogre_Idle_000;
            this.pbMonster5.Location = new System.Drawing.Point(535, 574);
            this.pbMonster5.Name = "pbMonster5";
            this.pbMonster5.Size = new System.Drawing.Size(143, 143);
            this.pbMonster5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonster5.TabIndex = 5;
            this.pbMonster5.TabStop = false;
            // 
            // pbMonster4
            // 
            this.pbMonster4.Image = global::HangMan.Properties.Resources._0_Minotaur_Idle_0001;
            this.pbMonster4.Location = new System.Drawing.Point(261, 451);
            this.pbMonster4.Name = "pbMonster4";
            this.pbMonster4.Size = new System.Drawing.Size(143, 143);
            this.pbMonster4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonster4.TabIndex = 5;
            this.pbMonster4.TabStop = false;
            // 
            // pbMonster3
            // 
            this.pbMonster3.Image = global::HangMan.Properties.Resources._0_Orc_Idle_000;
            this.pbMonster3.Location = new System.Drawing.Point(386, 266);
            this.pbMonster3.Name = "pbMonster3";
            this.pbMonster3.Size = new System.Drawing.Size(143, 143);
            this.pbMonster3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonster3.TabIndex = 5;
            this.pbMonster3.TabStop = false;
            // 
            // pbMonster2
            // 
            this.pbMonster2.Image = global::HangMan.Properties.Resources.Wraith_03_Idle_000;
            this.pbMonster2.Location = new System.Drawing.Point(701, 247);
            this.pbMonster2.Name = "pbMonster2";
            this.pbMonster2.Size = new System.Drawing.Size(143, 143);
            this.pbMonster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonster2.TabIndex = 5;
            this.pbMonster2.TabStop = false;
            // 
            // pbMonster
            // 
            this.pbMonster.Image = global::HangMan.Properties.Resources._0_Goblin_Idle_000;
            this.pbMonster.Location = new System.Drawing.Point(517, 34);
            this.pbMonster.Name = "pbMonster";
            this.pbMonster.Size = new System.Drawing.Size(143, 143);
            this.pbMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonster.TabIndex = 5;
            this.pbMonster.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::HangMan.Properties.Resources.levels;
            this.pbBackground.Location = new System.Drawing.Point(0, 28);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1130, 768);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // Levels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1130, 796);
            this.Controls.Add(this.pbLevel5);
            this.Controls.Add(this.pbLevel4);
            this.Controls.Add(this.pbLevel3);
            this.Controls.Add(this.pbLevel2);
            this.Controls.Add(this.pbLevel1);
            this.Controls.Add(this.pDragForm);
            this.Controls.Add(this.pbMonster5);
            this.Controls.Add(this.pbMonster4);
            this.Controls.Add(this.pbMonster3);
            this.Controls.Add(this.pbMonster2);
            this.Controls.Add(this.pbMonster);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Levels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Levels";
            this.pDragForm.ResumeLayout(false);
            this.pDragForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLevel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Label lblTItle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pDragForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbMonster;
        private System.Windows.Forms.PictureBox pbMonster2;
        private System.Windows.Forms.PictureBox pbMonster3;
        private System.Windows.Forms.PictureBox pbMonster4;
        private System.Windows.Forms.PictureBox pbMonster5;
        public System.Windows.Forms.PictureBox pbLevel1;
        public System.Windows.Forms.PictureBox pbLevel2;
        public System.Windows.Forms.PictureBox pbLevel3;
        public System.Windows.Forms.PictureBox pbLevel4;
        public System.Windows.Forms.PictureBox pbLevel5;
    }
}