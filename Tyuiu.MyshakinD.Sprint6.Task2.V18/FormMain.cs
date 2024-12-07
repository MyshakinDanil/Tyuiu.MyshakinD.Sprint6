using Tyuiu.MyshakinD.Sprint6.Task2.V18.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task2.V18 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxstartValue.Text);
                int stopStep = Convert.ToInt32(textBoxstopValue.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction.Titles.Add("график функции");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Были введены неверные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-24-1 Мышакин Данил", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGetResult_MouseEnter(object sender, EventArgs e)
        {
            buttonGetResult.BackColor = Color.Aquamarine;
        }

        private void buttonGetResult_MouseLeave(object sender, EventArgs e)
        {
            buttonGetResult.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void buttonGetResult_MouseDown(object sender, MouseEventArgs e)
        {
            buttonGetResult.BackColor = Color.GhostWhite;
        }
    }
}
