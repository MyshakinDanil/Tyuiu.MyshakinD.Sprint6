namespace Tyuiu.MyshakinD.Sprint6.Task6.V5 {
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelControl = new Panel();
            buttonHelp = new Button();
            buttonGetResult = new Button();
            buttonUploadFile = new Button();
            panelTask = new Panel();
            groupBoxNameTask = new GroupBox();
            textBoxTask = new TextBox();
            panelInput = new Panel();
            groupBoxInput = new GroupBox();
            textBoxInputData = new TextBox();
            splitter1 = new Splitter();
            panelOutput = new Panel();
            groupBoxOutput = new GroupBox();
            textBoxOutputData = new TextBox();
            toolTipControls = new ToolTip(components);
            openFileDialogChooseFile = new OpenFileDialog();
            panelControl.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxNameTask.SuspendLayout();
            panelInput.SuspendLayout();
            groupBoxInput.SuspendLayout();
            panelOutput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.Controls.Add(buttonHelp);
            panelControl.Controls.Add(buttonGetResult);
            panelControl.Controls.Add(buttonUploadFile);
            panelControl.Dock = DockStyle.Top;
            panelControl.Location = new Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1033, 87);
            panelControl.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(945, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(76, 69);
            buttonHelp.TabIndex = 2;
            toolTipControls.SetToolTip(buttonHelp, "Информация о программе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonGetResult
            // 
            buttonGetResult.Enabled = false;
            buttonGetResult.Image = (Image)resources.GetObject("buttonGetResult.Image");
            buttonGetResult.Location = new Point(99, 12);
            buttonGetResult.Name = "buttonGetResult";
            buttonGetResult.Size = new Size(79, 69);
            buttonGetResult.TabIndex = 1;
            toolTipControls.SetToolTip(buttonGetResult, "Вывести из файла слова, в которых встречается буква \"l\"");
            buttonGetResult.UseVisualStyleBackColor = true;
            buttonGetResult.Click += buttonGetResult_Click;
            // 
            // buttonUploadFile
            // 
            buttonUploadFile.Cursor = Cursors.Hand;
            buttonUploadFile.Image = (Image)resources.GetObject("buttonUploadFile.Image");
            buttonUploadFile.Location = new Point(12, 12);
            buttonUploadFile.Name = "buttonUploadFile";
            buttonUploadFile.Size = new Size(81, 69);
            buttonUploadFile.TabIndex = 0;
            toolTipControls.SetToolTip(buttonUploadFile, "Открыть файл\r\n");
            buttonUploadFile.UseVisualStyleBackColor = true;
            buttonUploadFile.Click += buttonUploadFile_Click;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxNameTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 87);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1033, 100);
            panelTask.TabIndex = 1;
            // 
            // groupBoxNameTask
            // 
            groupBoxNameTask.Controls.Add(textBoxTask);
            groupBoxNameTask.Dock = DockStyle.Fill;
            groupBoxNameTask.Location = new Point(0, 0);
            groupBoxNameTask.Name = "groupBoxNameTask";
            groupBoxNameTask.Size = new Size(1033, 100);
            groupBoxNameTask.TabIndex = 0;
            groupBoxNameTask.TabStop = false;
            groupBoxNameTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Dock = DockStyle.Fill;
            textBoxTask.Font = new Font("Segoe UI", 14F);
            textBoxTask.Location = new Point(3, 19);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(1027, 78);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panelInput
            // 
            panelInput.Controls.Add(groupBoxInput);
            panelInput.Dock = DockStyle.Left;
            panelInput.Location = new Point(0, 187);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(475, 396);
            panelInput.TabIndex = 2;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxInputData);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(475, 396);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // textBoxInputData
            // 
            textBoxInputData.BackColor = SystemColors.ControlLightLight;
            textBoxInputData.Dock = DockStyle.Fill;
            textBoxInputData.Location = new Point(3, 19);
            textBoxInputData.Multiline = true;
            textBoxInputData.Name = "textBoxInputData";
            textBoxInputData.ReadOnly = true;
            textBoxInputData.Size = new Size(469, 374);
            textBoxInputData.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(475, 187);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 396);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panelOutput
            // 
            panelOutput.Controls.Add(groupBoxOutput);
            panelOutput.Dock = DockStyle.Fill;
            panelOutput.Location = new Point(478, 187);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(555, 396);
            panelOutput.TabIndex = 4;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxOutputData);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(555, 396);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод";
            // 
            // textBoxOutputData
            // 
            textBoxOutputData.BackColor = SystemColors.ControlLightLight;
            textBoxOutputData.Dock = DockStyle.Fill;
            textBoxOutputData.Location = new Point(3, 19);
            textBoxOutputData.Multiline = true;
            textBoxOutputData.Name = "textBoxOutputData";
            textBoxOutputData.ReadOnly = true;
            textBoxOutputData.Size = new Size(549, 374);
            textBoxOutputData.TabIndex = 0;
            // 
            // toolTipControls
            // 
            toolTipControls.ToolTipIcon = ToolTipIcon.Info;
            toolTipControls.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogChooseFile
            // 
            openFileDialogChooseFile.FileName = "openFileDialogChooseFile";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 583);
            Controls.Add(panelOutput);
            Controls.Add(splitter1);
            Controls.Add(panelInput);
            Controls.Add(panelTask);
            Controls.Add(panelControl);
            MinimumSize = new Size(1049, 622);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Мышакин Д. | ПКТб-24-1";
            Load += FormMain_Load;
            panelControl.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxNameTask.ResumeLayout(false);
            groupBoxNameTask.PerformLayout();
            panelInput.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            panelOutput.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControl;
        private Panel panelTask;
        private GroupBox groupBoxNameTask;
        private Panel panelInput;
        private Button buttonUploadFile;
        private TextBox textBoxTask;
        private GroupBox groupBoxInput;
        private TextBox textBoxInputData;
        private Splitter splitter1;
        private Panel panelOutput;
        private GroupBox groupBoxOutput;
        private TextBox textBoxOutputData;
        private Button buttonHelp;
        private Button buttonGetResult;
        private ToolTip toolTipControls;
        private OpenFileDialog openFileDialogChooseFile;
    }
}
