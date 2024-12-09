namespace Tyuiu.MyshakinD.Sprint6.Task4.V9 {
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelControl = new Panel();
            buttonGetResult = new Button();
            buttonSave = new Button();
            buttonHelp = new Button();
            groupBoxInput = new GroupBox();
            textBoxstopValue = new TextBox();
            textBoxNamestopValue = new TextBox();
            textBoxstartValue = new TextBox();
            textBoxNamestartValue = new TextBox();
            groupBoxNameTask = new GroupBox();
            pictureBoxTask = new PictureBox();
            panel2 = new Panel();
            groupBoxOutput = new GroupBox();
            textBoxResult = new TextBox();
            panelGraph = new Panel();
            chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelControl.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxNameTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).BeginInit();
            panel2.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            panelGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGraph).BeginInit();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.Controls.Add(buttonGetResult);
            panelControl.Controls.Add(buttonSave);
            panelControl.Controls.Add(buttonHelp);
            panelControl.Controls.Add(groupBoxInput);
            panelControl.Controls.Add(groupBoxNameTask);
            panelControl.Dock = DockStyle.Top;
            panelControl.Location = new Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(1361, 203);
            panelControl.TabIndex = 0;
            // 
            // buttonGetResult
            // 
            buttonGetResult.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonGetResult.BackColor = Color.FromArgb(192, 192, 255);
            buttonGetResult.Location = new Point(1205, 20);
            buttonGetResult.Name = "buttonGetResult";
            buttonGetResult.Size = new Size(144, 42);
            buttonGetResult.TabIndex = 4;
            buttonGetResult.Text = "Выполнить";
            buttonGetResult.UseVisualStyleBackColor = false;
            buttonGetResult.Click += buttonGetResult_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Thistle;
            buttonSave.Location = new Point(955, 20);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(103, 42);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaption;
            buttonHelp.Location = new Point(848, 20);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(101, 42);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxstopValue);
            groupBoxInput.Controls.Add(textBoxNamestopValue);
            groupBoxInput.Controls.Add(textBoxstartValue);
            groupBoxInput.Controls.Add(textBoxNamestartValue);
            groupBoxInput.Location = new Point(521, 12);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(321, 179);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод";
            // 
            // textBoxstopValue
            // 
            textBoxstopValue.Location = new Point(6, 141);
            textBoxstopValue.Name = "textBoxstopValue";
            textBoxstopValue.Size = new Size(309, 23);
            textBoxstopValue.TabIndex = 3;
            textBoxstopValue.Text = "5";
            // 
            // textBoxNamestopValue
            // 
            textBoxNamestopValue.BorderStyle = BorderStyle.None;
            textBoxNamestopValue.Location = new Point(6, 101);
            textBoxNamestopValue.Name = "textBoxNamestopValue";
            textBoxNamestopValue.ReadOnly = true;
            textBoxNamestopValue.Size = new Size(100, 16);
            textBoxNamestopValue.TabIndex = 2;
            textBoxNamestopValue.Text = "Конец шага:";
            // 
            // textBoxstartValue
            // 
            textBoxstartValue.Location = new Point(6, 51);
            textBoxstartValue.Name = "textBoxstartValue";
            textBoxstartValue.Size = new Size(309, 23);
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
            // groupBoxNameTask
            // 
            groupBoxNameTask.Controls.Add(pictureBoxTask);
            groupBoxNameTask.Location = new Point(3, 3);
            groupBoxNameTask.Name = "groupBoxNameTask";
            groupBoxNameTask.Size = new Size(512, 194);
            groupBoxNameTask.TabIndex = 0;
            groupBoxNameTask.TabStop = false;
            groupBoxNameTask.Text = "Условие";
            // 
            // pictureBoxTask
            // 
            pictureBoxTask.Image = (Image)resources.GetObject("pictureBoxTask.Image");
            pictureBoxTask.Location = new Point(6, 22);
            pictureBoxTask.Name = "pictureBoxTask";
            pictureBoxTask.Size = new Size(499, 166);
            pictureBoxTask.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask.TabIndex = 0;
            pictureBoxTask.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxOutput);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 203);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 419);
            panel2.TabIndex = 1;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Dock = DockStyle.Fill;
            groupBoxOutput.Location = new Point(0, 0);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(310, 419);
            groupBoxOutput.TabIndex = 0;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод";
            groupBoxOutput.Enter += groupBoxOutput_Enter;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ControlLightLight;
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 19);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(304, 397);
            textBoxResult.TabIndex = 0;
            // 
            // panelGraph
            // 
            panelGraph.Controls.Add(chartGraph);
            panelGraph.Dock = DockStyle.Fill;
            panelGraph.Location = new Point(310, 203);
            panelGraph.Name = "panelGraph";
            panelGraph.Size = new Size(1051, 419);
            panelGraph.TabIndex = 2;
            // 
            // chartGraph
            // 
            chartArea1.Name = "ChartArea1";
            chartGraph.ChartAreas.Add(chartArea1);
            chartGraph.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartGraph.Legends.Add(legend1);
            chartGraph.Location = new Point(0, 0);
            chartGraph.Name = "chartGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGraph.Series.Add(series1);
            chartGraph.Size = new Size(1051, 419);
            chartGraph.TabIndex = 0;
            chartGraph.Text = "chart1";
            title1.Name = "График функции F(x)";
            title1.Text = "График функции F(x)";
            chartGraph.Titles.Add(title1);
            // 
            // splitter1
            // 
            splitter1.Location = new Point(310, 203);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 419);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 622);
            Controls.Add(splitter1);
            Controls.Add(panelGraph);
            Controls.Add(panel2);
            Controls.Add(panelControl);
            MinimumSize = new Size(1377, 661);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Мышакин Д. | ПКТб-24-1";
            panelControl.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxNameTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).EndInit();
            panel2.ResumeLayout(false);
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            panelGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGraph).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControl;
        private Panel panel2;
        private Panel panelGraph;
        private Splitter splitter1;
        private GroupBox groupBoxOutput;
        private GroupBox groupBoxNameTask;
        private TextBox textBoxResult;
        private GroupBox groupBoxInput;
        private TextBox textBoxstopValue;
        private TextBox textBoxNamestopValue;
        private TextBox textBoxstartValue;
        private TextBox textBoxNamestartValue;
        private PictureBox pictureBoxTask;
        private Button buttonHelp;
        private Button buttonGetResult;
        private Button buttonSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
    }
}
