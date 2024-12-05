namespace Tyuiu.MyshakinD.Sprint6.Task1.V5 {
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
            pictureBoxTask = new PictureBox();
            groupBoxInput = new GroupBox();
            textBoxstopValue = new TextBox();
            textBoxNamestopValue = new TextBox();
            textBoxstartValue = new TextBox();
            textBoxNamestartValue = new TextBox();
            groupBoxOutput = new GroupBox();
            textBoxResult = new TextBox();
            textBoxNameResult = new TextBox();
            buttonGetResult = new Button();
            buttonHelp = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(653, 243);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // pictureBoxTask
            // 
            pictureBoxTask.Image = (Image)resources.GetObject("pictureBoxTask.Image");
            pictureBoxTask.Location = new Point(6, 22);
            pictureBoxTask.Name = "pictureBoxTask";
            pictureBoxTask.Size = new Size(636, 205);
            pictureBoxTask.TabIndex = 0;
            pictureBoxTask.TabStop = false;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxstopValue);
            groupBoxInput.Controls.Add(textBoxNamestopValue);
            groupBoxInput.Controls.Add(textBoxstartValue);
            groupBoxInput.Controls.Add(textBoxNamestartValue);
            groupBoxInput.Location = new Point(12, 310);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(348, 100);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxstopValue
            // 
            textBoxstopValue.Location = new Point(185, 56);
            textBoxstopValue.Name = "textBoxstopValue";
            textBoxstopValue.Size = new Size(156, 23);
            textBoxstopValue.TabIndex = 3;
            textBoxstopValue.Text = "5";
            // 
            // textBoxNamestopValue
            // 
            textBoxNamestopValue.BorderStyle = BorderStyle.None;
            textBoxNamestopValue.Location = new Point(185, 19);
            textBoxNamestopValue.Name = "textBoxNamestopValue";
            textBoxNamestopValue.ReadOnly = true;
            textBoxNamestopValue.Size = new Size(100, 16);
            textBoxNamestopValue.TabIndex = 2;
            textBoxNamestopValue.Text = "Конец шага:";
            // 
            // textBoxstartValue
            // 
            textBoxstartValue.Location = new Point(6, 56);
            textBoxstartValue.Name = "textBoxstartValue";
            textBoxstartValue.Size = new Size(157, 23);
            textBoxstartValue.TabIndex = 1;
            textBoxstartValue.Text = "-5";
            // 
            // textBoxNamestartValue
            // 
            textBoxNamestartValue.BorderStyle = BorderStyle.None;
            textBoxNamestartValue.Location = new Point(6, 22);
            textBoxNamestartValue.Name = "textBoxNamestartValue";
            textBoxNamestartValue.ReadOnly = true;
            textBoxNamestartValue.Size = new Size(100, 16);
            textBoxNamestartValue.TabIndex = 0;
            textBoxNamestartValue.Text = "Старт шага:";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Controls.Add(textBoxNameResult);
            groupBoxOutput.Location = new Point(683, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(379, 426);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ControlLightLight;
            textBoxResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 44);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(367, 376);
            textBoxResult.TabIndex = 1;
            // 
            // textBoxNameResult
            // 
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
            buttonGetResult.BackColor = Color.PaleTurquoise;
            buttonGetResult.Location = new Point(503, 332);
            buttonGetResult.Name = "buttonGetResult";
            buttonGetResult.Size = new Size(151, 57);
            buttonGetResult.TabIndex = 3;
            buttonGetResult.Text = "Выполнить";
            buttonGetResult.UseVisualStyleBackColor = false;
            buttonGetResult.Click += buttonGetResult_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(192, 192, 255);
            buttonHelp.Font = new Font("Segoe UI", 9F);
            buttonHelp.Location = new Point(429, 332);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(68, 57);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonGetResult);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Мышакин Д. | ПКТб-24-1";
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private PictureBox pictureBoxTask;
        private GroupBox groupBoxInput;
        private TextBox textBoxstopValue;
        private TextBox textBoxNamestopValue;
        private TextBox textBoxstartValue;
        private TextBox textBoxNamestartValue;
        private GroupBox groupBoxOutput;
        private TextBox textBoxResult;
        private TextBox textBoxNameResult;
        private Button buttonGetResult;
        private Button buttonHelp;
    }
}
