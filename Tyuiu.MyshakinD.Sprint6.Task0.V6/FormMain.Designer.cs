namespace Tyuiu.MyshakinD.Sprint6.Task0.V6 {
    partial class FormMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask = new GroupBox();
            textBoxTaskText = new TextBox();
            pictureBoxTaskImage = new PictureBox();
            groupBoxGetData = new GroupBox();
            textBoxValueX = new TextBox();
            textBoxNameValueX = new TextBox();
            groupBoxShowResult = new GroupBox();
            textBoxResult = new TextBox();
            textBoxNameResult = new TextBox();
            buttonGetResult = new Button();
            buttonHelp = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTaskImage).BeginInit();
            groupBoxGetData.SuspendLayout();
            groupBoxShowResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTaskText);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(532, 250);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTaskText
            // 
            textBoxTaskText.BorderStyle = BorderStyle.None;
            textBoxTaskText.Font = new Font("Segoe UI", 13F);
            textBoxTaskText.Location = new Point(6, 22);
            textBoxTaskText.Multiline = true;
            textBoxTaskText.Name = "textBoxTaskText";
            textBoxTaskText.ReadOnly = true;
            textBoxTaskText.Size = new Size(520, 222);
            textBoxTaskText.TabIndex = 0;
            textBoxTaskText.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой. Графический интерфейс оформить по шаблону из лекции.";
            // 
            // pictureBoxTaskImage
            // 
            pictureBoxTaskImage.Image = (Image)resources.GetObject("pictureBoxTaskImage.Image");
            pictureBoxTaskImage.Location = new Point(550, 34);
            pictureBoxTaskImage.Name = "pictureBoxTaskImage";
            pictureBoxTaskImage.Size = new Size(238, 68);
            pictureBoxTaskImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxTaskImage.TabIndex = 1;
            pictureBoxTaskImage.TabStop = false;
            // 
            // groupBoxGetData
            // 
            groupBoxGetData.Controls.Add(textBoxValueX);
            groupBoxGetData.Controls.Add(textBoxNameValueX);
            groupBoxGetData.Location = new Point(18, 295);
            groupBoxGetData.Name = "groupBoxGetData";
            groupBoxGetData.Size = new Size(200, 100);
            groupBoxGetData.TabIndex = 2;
            groupBoxGetData.TabStop = false;
            groupBoxGetData.Text = "Ввод данных";
            // 
            // textBoxValueX
            // 
            textBoxValueX.BackColor = SystemColors.ControlLightLight;
            textBoxValueX.Location = new Point(46, 62);
            textBoxValueX.Name = "textBoxValueX";
            textBoxValueX.ReadOnly = true;
            textBoxValueX.Size = new Size(100, 23);
            textBoxValueX.TabIndex = 1;
            textBoxValueX.Text = "3";
            textBoxValueX.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxNameValueX
            // 
            textBoxNameValueX.BorderStyle = BorderStyle.None;
            textBoxNameValueX.Location = new Point(6, 22);
            textBoxNameValueX.Name = "textBoxNameValueX";
            textBoxNameValueX.ReadOnly = true;
            textBoxNameValueX.Size = new Size(100, 16);
            textBoxNameValueX.TabIndex = 0;
            textBoxNameValueX.Text = "Значение x =";
            // 
            // groupBoxShowResult
            // 
            groupBoxShowResult.Controls.Add(textBoxResult);
            groupBoxShowResult.Controls.Add(textBoxNameResult);
            groupBoxShowResult.Location = new Point(338, 295);
            groupBoxShowResult.Name = "groupBoxShowResult";
            groupBoxShowResult.Size = new Size(200, 100);
            groupBoxShowResult.TabIndex = 3;
            groupBoxShowResult.TabStop = false;
            groupBoxShowResult.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ControlLightLight;
            textBoxResult.Location = new Point(40, 62);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 1;
            // 
            // textBoxNameResult
            // 
            textBoxNameResult.BackColor = SystemColors.Control;
            textBoxNameResult.BorderStyle = BorderStyle.None;
            textBoxNameResult.Location = new Point(6, 22);
            textBoxNameResult.Name = "textBoxNameResult";
            textBoxNameResult.ReadOnly = true;
            textBoxNameResult.Size = new Size(100, 16);
            textBoxNameResult.TabIndex = 0;
            textBoxNameResult.Text = "Результат:";
            // 
            // buttonGetResult
            // 
            buttonGetResult.Location = new Point(678, 387);
            buttonGetResult.Name = "buttonGetResult";
            buttonGetResult.Size = new Size(110, 38);
            buttonGetResult.TabIndex = 4;
            buttonGetResult.Text = "Выполнить";
            buttonGetResult.UseVisualStyleBackColor = true;
            buttonGetResult.Click += buttonGetResult_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Segoe UI", 13F);
            buttonHelp.Location = new Point(626, 387);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(46, 38);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonGetResult);
            Controls.Add(groupBoxShowResult);
            Controls.Add(groupBoxGetData);
            Controls.Add(pictureBoxTaskImage);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Мышакин Д. | ПКТб-24-1";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTaskImage).EndInit();
            groupBoxGetData.ResumeLayout(false);
            groupBoxGetData.PerformLayout();
            groupBoxShowResult.ResumeLayout(false);
            groupBoxShowResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTaskText;
        private PictureBox pictureBoxTaskImage;
        private GroupBox groupBoxGetData;
        private TextBox textBoxValueX;
        private TextBox textBoxNameValueX;
        private GroupBox groupBoxShowResult;
        private TextBox textBoxResult;
        private TextBox textBoxNameResult;
        private Button buttonGetResult;
        private Button buttonHelp;
    }
}
