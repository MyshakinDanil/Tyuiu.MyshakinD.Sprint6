namespace Tyuiu.MyshakinD.Sprint6.Task6.V5 {
    partial class FormAbout {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar = new PictureBox();
            textBoxAbout = new TextBox();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Image = (Image)resources.GetObject("pictureBoxAvatar.Image");
            pictureBoxAvatar.Location = new Point(12, 12);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(169, 231);
            pictureBoxAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            // 
            // textBoxAbout
            // 
            textBoxAbout.Location = new Point(187, 12);
            textBoxAbout.Multiline = true;
            textBoxAbout.Name = "textBoxAbout";
            textBoxAbout.ReadOnly = true;
            textBoxAbout.Size = new Size(333, 213);
            textBoxAbout.TabIndex = 1;
            textBoxAbout.Text = resources.GetString("textBoxAbout.Text");
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(418, 231);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(102, 33);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 276);
            Controls.Add(buttonOK);
            Controls.Add(textBoxAbout);
            Controls.Add(pictureBoxAvatar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar;
        private TextBox textBoxAbout;
        private Button buttonOK;
    }
}