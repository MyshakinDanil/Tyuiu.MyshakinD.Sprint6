using Tyuiu.MyshakinD.Sprint6.Task5.V22.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task5.V22 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint5\InPutDataFileTask5V22.txt";


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-24-1 Мышакин Данил", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            dataGridViewNums.ColumnCount = 2;
            dataGridViewNums.Columns[0].Width = 20;
            dataGridViewNums.Columns[1].Width = 50;

            this.chartResultGraph.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResultGraph.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResultGraph.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numMass.Length; i++)
            {
                dataGridViewNums.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResultGraph.Series[0].Points.AddXY(i, numMass[i]);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
