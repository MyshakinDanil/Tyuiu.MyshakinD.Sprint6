namespace Tyuiu.MyshakinD.Sprint6.Task2.V18 {
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
            groupBoxNameTask = new GroupBox();
            pictureBoxTask = new PictureBox();
            groupBoxInputData = new GroupBox();
            textBoxstopValue = new TextBox();
            textBoxNamestopValue = new TextBox();
            textBoxstartValue = new TextBox();
            textBoxNamestartValue = new TextBox();
            groupBoxOutputData = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            FunctionResult = new DataGridViewTextBoxColumn();
            buttonGetResult = new Button();
            buttonHelp = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxNameTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).BeginInit();
            groupBoxInputData.SuspendLayout();
            groupBoxOutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxNameTask
            // 
            groupBoxNameTask.Controls.Add(pictureBoxTask);
            groupBoxNameTask.Location = new Point(12, 12);
            groupBoxNameTask.Name = "groupBoxNameTask";
            groupBoxNameTask.Size = new Size(658, 242);
            groupBoxNameTask.TabIndex = 0;
            groupBoxNameTask.TabStop = false;
            groupBoxNameTask.Text = "Условие";
            // 
            // pictureBoxTask
            // 
            pictureBoxTask.Image = (Image)resources.GetObject("pictureBoxTask.Image");
            pictureBoxTask.Location = new Point(6, 22);
            pictureBoxTask.Name = "pictureBoxTask";
            pictureBoxTask.Size = new Size(642, 203);
            pictureBoxTask.TabIndex = 0;
            pictureBoxTask.TabStop = false;
            // 
            // groupBoxInputData
            // 
            groupBoxInputData.Controls.Add(textBoxstopValue);
            groupBoxInputData.Controls.Add(textBoxNamestopValue);
            groupBoxInputData.Controls.Add(textBoxstartValue);
            groupBoxInputData.Controls.Add(textBoxNamestartValue);
            groupBoxInputData.Location = new Point(18, 307);
            groupBoxInputData.Name = "groupBoxInputData";
            groupBoxInputData.Size = new Size(369, 100);
            groupBoxInputData.TabIndex = 1;
            groupBoxInputData.TabStop = false;
            groupBoxInputData.Text = "Ввод данных";
            // 
            // textBoxstopValue
            // 
            textBoxstopValue.Location = new Point(175, 44);
            textBoxstopValue.Name = "textBoxstopValue";
            textBoxstopValue.Size = new Size(146, 23);
            textBoxstopValue.TabIndex = 3;
            textBoxstopValue.Text = "5";
            // 
            // textBoxNamestopValue
            // 
            textBoxNamestopValue.BorderStyle = BorderStyle.None;
            textBoxNamestopValue.Location = new Point(175, 22);
            textBoxNamestopValue.Name = "textBoxNamestopValue";
            textBoxNamestopValue.ReadOnly = true;
            textBoxNamestopValue.Size = new Size(100, 16);
            textBoxNamestopValue.TabIndex = 2;
            textBoxNamestopValue.Text = "Конец шага:";
            // 
            // textBoxstartValue
            // 
            textBoxstartValue.Location = new Point(6, 44);
            textBoxstartValue.Name = "textBoxstartValue";
            textBoxstartValue.Size = new Size(144, 23);
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
            // groupBoxOutputData
            // 
            groupBoxOutputData.Controls.Add(chartFunction);
            groupBoxOutputData.Controls.Add(dataGridViewFunction);
            groupBoxOutputData.Location = new Point(676, 12);
            groupBoxOutputData.Name = "groupBoxOutputData";
            groupBoxOutputData.Size = new Size(701, 426);
            groupBoxOutputData.TabIndex = 2;
            groupBoxOutputData.TabStop = false;
            groupBoxOutputData.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(166, 22);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(529, 398);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.AllowUserToAddRows = false;
            dataGridViewFunction.AllowUserToDeleteRows = false;
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, FunctionResult });
            dataGridViewFunction.Location = new Point(6, 22);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.ReadOnly = true;
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.Size = new Size(154, 398);
            dataGridViewFunction.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 75;
            // 
            // FunctionResult
            // 
            FunctionResult.HeaderText = "F(X)";
            FunctionResult.Name = "FunctionResult";
            FunctionResult.ReadOnly = true;
            FunctionResult.Width = 75;
            // 
            // buttonGetResult
            // 
            buttonGetResult.BackColor = Color.FromArgb(192, 192, 255);
            buttonGetResult.Location = new Point(539, 333);
            buttonGetResult.Name = "buttonGetResult";
            buttonGetResult.Size = new Size(121, 56);
            buttonGetResult.TabIndex = 3;
            buttonGetResult.Text = "Выполнить";
            buttonGetResult.UseVisualStyleBackColor = false;
            buttonGetResult.Click += buttonGetResult_Click;
            buttonGetResult.MouseDown += buttonGetResult_MouseDown;
            buttonGetResult.MouseEnter += buttonGetResult_MouseEnter;
            buttonGetResult.MouseLeave += buttonGetResult_MouseLeave;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.LightSkyBlue;
            buttonHelp.Location = new Point(462, 333);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(71, 56);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 450);
            Controls.Add(buttonHelp);
            Controls.Add(buttonGetResult);
            Controls.Add(groupBoxOutputData);
            Controls.Add(groupBoxInputData);
            Controls.Add(groupBoxNameTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Выполнил: Мышакин Д. | ПКТб-24-1";
            groupBoxNameTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).EndInit();
            groupBoxInputData.ResumeLayout(false);
            groupBoxInputData.PerformLayout();
            groupBoxOutputData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxNameTask;
        private PictureBox pictureBoxTask;
        private GroupBox groupBoxInputData;
        private TextBox textBoxstopValue;
        private TextBox textBoxNamestopValue;
        private TextBox textBoxstartValue;
        private TextBox textBoxNamestartValue;
        private GroupBox groupBoxOutputData;
        private Button buttonGetResult;
        private Button buttonHelp;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FunctionResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
