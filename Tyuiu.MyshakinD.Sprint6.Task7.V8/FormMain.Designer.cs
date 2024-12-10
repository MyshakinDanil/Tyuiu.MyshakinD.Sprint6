namespace Tyuiu.MyshakinD.Sprint6.Task7.V8 {
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
            panelControls = new Panel();
            buttonHelp = new Button();
            buttonSaveFile = new Button();
            buttonGetResult = new Button();
            buttonLoadFile = new Button();
            panelTask = new Panel();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panelInput = new Panel();
            dataGridViewInputData = new DataGridView();
            splitter1 = new Splitter();
            panelOutput = new Panel();
            dataGridViewOutputData = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            saveFileDialogMatrix = new OpenFileDialog();
            panelControls.SuspendLayout();
            panelTask.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputData).BeginInit();
            panelOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputData).BeginInit();
            SuspendLayout();
            // 
            // panelControls
            // 
            panelControls.Controls.Add(buttonHelp);
            panelControls.Controls.Add(buttonSaveFile);
            panelControls.Controls.Add(buttonGetResult);
            panelControls.Controls.Add(buttonLoadFile);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 0);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(1118, 100);
            panelControls.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Cursor = Cursors.Hand;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(1012, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 82);
            buttonHelp.TabIndex = 3;
            toolTip1.SetToolTip(buttonHelp, "О программе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.Cursor = Cursors.Hand;
            buttonSaveFile.Enabled = false;
            buttonSaveFile.Image = (Image)resources.GetObject("buttonSaveFile.Image");
            buttonSaveFile.Location = new Point(212, 12);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(94, 82);
            buttonSaveFile.TabIndex = 2;
            toolTip1.SetToolTip(buttonSaveFile, "Сохранить данные в файл");
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonGetResult
            // 
            buttonGetResult.Cursor = Cursors.Hand;
            buttonGetResult.Enabled = false;
            buttonGetResult.Image = (Image)resources.GetObject("buttonGetResult.Image");
            buttonGetResult.Location = new Point(112, 12);
            buttonGetResult.Name = "buttonGetResult";
            buttonGetResult.Size = new Size(94, 82);
            buttonGetResult.TabIndex = 1;
            toolTip1.SetToolTip(buttonGetResult, "Выполнить операцию над данными из файла");
            buttonGetResult.UseVisualStyleBackColor = true;
            buttonGetResult.Click += buttonGetResult_Click;
            // 
            // buttonLoadFile
            // 
            buttonLoadFile.Cursor = Cursors.Hand;
            buttonLoadFile.Image = (Image)resources.GetObject("buttonLoadFile.Image");
            buttonLoadFile.Location = new Point(12, 12);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new Size(94, 82);
            buttonLoadFile.TabIndex = 0;
            toolTip1.SetToolTip(buttonLoadFile, "Загрузить файл");
            buttonLoadFile.UseVisualStyleBackColor = true;
            buttonLoadFile.Click += buttonLoadFile_Click;
            // 
            // panelTask
            // 
            panelTask.Controls.Add(groupBoxTask);
            panelTask.Dock = DockStyle.Top;
            panelTask.Location = new Point(0, 100);
            panelTask.Name = "panelTask";
            panelTask.Size = new Size(1118, 119);
            panelTask.TabIndex = 1;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Dock = DockStyle.Fill;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(1118, 119);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Dock = DockStyle.Fill;
            textBoxTask.Font = new Font("Segoe UI", 13F);
            textBoxTask.Location = new Point(3, 19);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(1112, 97);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panelInput
            // 
            panelInput.Controls.Add(dataGridViewInputData);
            panelInput.Dock = DockStyle.Left;
            panelInput.Location = new Point(0, 219);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(546, 422);
            panelInput.TabIndex = 2;
            // 
            // dataGridViewInputData
            // 
            dataGridViewInputData.AllowUserToAddRows = false;
            dataGridViewInputData.AllowUserToDeleteRows = false;
            dataGridViewInputData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInputData.ColumnHeadersVisible = false;
            dataGridViewInputData.Dock = DockStyle.Fill;
            dataGridViewInputData.Location = new Point(0, 0);
            dataGridViewInputData.Name = "dataGridViewInputData";
            dataGridViewInputData.ReadOnly = true;
            dataGridViewInputData.RowHeadersVisible = false;
            dataGridViewInputData.Size = new Size(546, 422);
            dataGridViewInputData.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(546, 219);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 422);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panelOutput
            // 
            panelOutput.Controls.Add(dataGridViewOutputData);
            panelOutput.Dock = DockStyle.Fill;
            panelOutput.Location = new Point(549, 219);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(569, 422);
            panelOutput.TabIndex = 4;
            // 
            // dataGridViewOutputData
            // 
            dataGridViewOutputData.AllowUserToAddRows = false;
            dataGridViewOutputData.AllowUserToDeleteRows = false;
            dataGridViewOutputData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutputData.ColumnHeadersVisible = false;
            dataGridViewOutputData.Dock = DockStyle.Fill;
            dataGridViewOutputData.Location = new Point(0, 0);
            dataGridViewOutputData.Name = "dataGridViewOutputData";
            dataGridViewOutputData.ReadOnly = true;
            dataGridViewOutputData.RowHeadersVisible = false;
            dataGridViewOutputData.Size = new Size(569, 422);
            dataGridViewOutputData.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // saveFileDialogMatrix
            // 
            saveFileDialogMatrix.FileName = "saveFileDialogMatrix";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 641);
            Controls.Add(panelOutput);
            Controls.Add(splitter1);
            Controls.Add(panelInput);
            Controls.Add(panelTask);
            Controls.Add(panelControls);
            MinimumSize = new Size(1134, 680);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Мышакин Д. | ПКТб-24-1";
            WindowState = FormWindowState.Maximized;
            panelControls.ResumeLayout(false);
            panelTask.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputData).EndInit();
            panelOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControls;
        private Button buttonHelp;
        private Button buttonSaveFile;
        private Button buttonGetResult;
        private Button buttonLoadFile;
        private Panel panelTask;
        private Panel panelInput;
        private Splitter splitter1;
        private Panel panelOutput;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private DataGridView dataGridViewInputData;
        private DataGridView dataGridViewOutputData;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip1;
        private OpenFileDialog saveFileDialogMatrix;
    }
}
