using Tyuiu.MyshakinD.Sprint6.Task4.V9.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task4.V9 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void groupBoxOutput_Enter(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-24-1 Мышакин Данил", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxstartValue.Text);
                int stopStep = Convert.ToInt32(textBoxstopValue.Text);

                int len = stopStep - startStep + 1;

                double[] valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartGraph.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraph.ChartAreas[0].AxisY.Title = "Ось F(X)";

                textBoxResult.Text = "";

                chartGraph.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartGraph.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V9.txt");
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " успешно сохранён!\nоткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
