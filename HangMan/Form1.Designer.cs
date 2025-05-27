namespace HangMan
{
    partial class Form1
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
            this.pDragForm = new System.Windows.Forms.Panel();
            this.lblTItle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pbMonster = new System.Windows.Forms.PictureBox();
            this.pbCharacter = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbSettings = new System.Windows.Forms.PictureBox();
            this.pbAdventure = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pDragForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdventure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pDragForm
            // 
            this.pDragForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.pDragForm.Controls.Add(this.lblTItle);
            this.pDragForm.Controls.Add(this.btnMinimize);
            this.pDragForm.Location = new System.Drawing.Point(0, 0);
            this.pDragForm.Name = "pDragForm";
            this.pDragForm.Size = new System.Drawing.Size(1130, 30);
            this.pDragForm.TabIndex = 3;
            this.pDragForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pDragForm_MouseDown);
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
            this.btnMinimize.Location = new System.Drawing.Point(1098, -23);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(32, 76);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pbMonster
            // 
            this.pbMonster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMonster.Image = global::HangMan.Properties.Resources.retreating;
            this.pbMonster.Location = new System.Drawing.Point(722, 260);
            this.pbMonster.Name = "pbMonster";
            this.pbMonster.Size = new System.Drawing.Size(144, 155);
            this.pbMonster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMonster.TabIndex = 2;
            this.pbMonster.TabStop = false;
            // 
            // pbCharacter
            // 
            this.pbCharacter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCharacter.Image = global::HangMan.Properties.Resources._0_Warrior_Idle_0001;
            this.pbCharacter.Location = new System.Drawing.Point(868, 531);
            this.pbCharacter.Name = "pbCharacter";
            this.pbCharacter.Size = new System.Drawing.Size(214, 221);
            this.pbCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCharacter.TabIndex = 2;
            this.pbCharacter.TabStop = false;
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = global::HangMan.Properties.Resources.Exit;
            this.pbExit.Location = new System.Drawing.Point(120, 538);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(219, 78);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbExit.TabIndex = 2;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbSettings
            // 
            this.pbSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSettings.Image = global::HangMan.Properties.Resources.settings;
            this.pbSettings.Location = new System.Drawing.Point(120, 430);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(219, 78);
            this.pbSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSettings.TabIndex = 2;
            this.pbSettings.TabStop = false;
            // 
            // pbAdventure
            // 
            this.pbAdventure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdventure.Image = global::HangMan.Properties.Resources.adventurenow;
            this.pbAdventure.Location = new System.Drawing.Point(75, 296);
            this.pbAdventure.Name = "pbAdventure";
            this.pbAdventure.Size = new System.Drawing.Size(309, 107);
            this.pbAdventure.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdventure.TabIndex = 2;
            this.pbAdventure.TabStop = false;
            this.pbAdventure.Click += new System.EventHandler(this.pbAdventure_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::HangMan.Properties.Resources.Hang_Man;
            this.pictureBox2.Location = new System.Drawing.Point(234, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(632, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::HangMan.Properties.Resources.firstpage;
            this.pbBackground.Location = new System.Drawing.Point(0, 28);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1130, 768);
            this.pbBackground.TabIndex = 0;
            this.pbBackground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 796);
            this.Controls.Add(this.pDragForm);
            this.Controls.Add(this.pbMonster);
            this.Controls.Add(this.pbCharacter);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbSettings);
            this.Controls.Add(this.pbAdventure);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pDragForm.ResumeLayout(false);
            this.pDragForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdventure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbAdventure;
        private System.Windows.Forms.PictureBox pbSettings;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbCharacter;
        private System.Windows.Forms.PictureBox pbMonster;
        private System.Windows.Forms.Panel pDragForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Label lblTItle;
    }
}

