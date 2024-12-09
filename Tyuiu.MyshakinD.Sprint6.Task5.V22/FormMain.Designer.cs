namespace Tyuiu.MyshakinD.Sprint6.Task5.V22 {
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelControl = new Panel();
            buttonGetResult = new Button();
            buttonOpenFile = new Button();
            buttonHelp = new Button();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panelOutput = new Panel();
            groupBoxOutput = new GroupBox();
            dataGridViewNums = new DataGridView();
            splitter1 = new Splitter();
            panelGraph = new Panel();
            chartResultGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelControl.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelOutput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResultGraph).BeginInit();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.Controls.Add(buttonGetResult);
            panelControl.Controls.Add(buttonOpenFile);
            panelControl.Controls.Add(buttonHelp);
            panelControl.Controls.Add(groupBoxTask);
            panelControl.Dock = DockStyle.Top;
            panelControl.Location = new Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1048, 128);
            panelControl.TabIndex = 0;
            // 
            // buttonGetResult
            // 
            buttonGetResult.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGetResult.BackColor = Color.FromArgb(192, 192, 255);
            buttonGetResult.Location = new Point(885, 12);
            buttonGetResult.Name = "buttonGetResult";
            buttonGetResult.Size = new Size(151, 39);
            buttonGetResult.TabIndex = 3;
            buttonGetResult.Text = "Выполнить";
            buttonGetResult.UseVisualStyleBackColor = false;
            buttonGetResult.Click += buttonGetResult_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = Color.LightBlue;
            buttonOpenFile.Location = new Point(654, 12);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(120, 39);
            buttonOpenFile.TabIndex = 2;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaption;
            buttonHelp.Location = new Point(530, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(118, 39);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(3, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(521, 119);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(509, 91);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panelOutput
            // 
            panelOutput.Controls.Add(groupBoxOutput);
            panelOutput.Dock = DockStyle.Left;
            panelOutput.Location = new Point(0, 128);
            panelOutput.Name = "panelOutput";
            panelOutput.Size = new Size(284, 514);
            panelOutput.TabIndex = 1;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewNums);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(284, 514);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод";
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.AllowUserToAddRows = false;
            dataGridViewNums.AllowUserToDeleteRows = false;
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.ColumnHeadersVisible = false;
            dataGridViewNums.Dock = DockStyle.Fill;
            dataGridViewNums.Location = new Point(3, 19);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.ReadOnly = true;
            dataGridViewNums.RowHeadersVisible = false;
            dataGridViewNums.Size = new Size(278, 492);
            dataGridViewNums.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(284, 128);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 514);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panelGraph
            // 
            panelGraph.Controls.Add(chartResultGraph);
            panelGraph.Dock = DockStyle.Fill;
            panelGraph.Location = new Point(287, 128);
            panelGraph.Name = "panelGraph";
            panelGraph.Size = new Size(761, 514);
            panelGraph.TabIndex = 3;
            // 
            // chartResultGraph
            // 
            chartArea1.Name = "ChartArea1";
            chartResultGraph.ChartAreas.Add(chartArea1);
            chartResultGraph.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartResultGraph.Legends.Add(legend1);
            chartResultGraph.Location = new Point(0, 0);
            chartResultGraph.Name = "chartResultGraph";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResultGraph.Series.Add(series1);
            chartResultGraph.Size = new Size(761, 514);
            chartResultGraph.TabIndex = 0;
            chartResultGraph.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 642);
            Controls.Add(panelGraph);
            Controls.Add(splitter1);
            Controls.Add(panelOutput);
            Controls.Add(panelControl);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Мышакин Д. | ПКТб-24-1";
            panelControl.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelOutput.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            panelGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResultGraph).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControl;
        private GroupBox groupBoxTask;
        private Panel panelOutput;
        private GroupBox groupBoxOutput;
        private Splitter splitter1;
        private Panel panelGraph;
        private Button buttonGetResult;
        private Button buttonOpenFile;
        private Button buttonHelp;
        private TextBox textBoxTask;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultGraph;
        private DataGridView dataGridViewNums;
    }
}
