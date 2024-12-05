namespace Tyuiu.MyshakinD.Sprint6.Task1.V5 {

    using Tyuiu.MyshakinD.Sprint6.Task1.V5.Lib;
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();

            try
            {
                int startValue = Convert.ToInt32(textBoxstartValue.Text);
                int stopValue = Convert.ToInt32(textBoxstopValue.Text);

                int len = stopValue - startValue + 1;

                double[] res = ds.GetMassFunction(startValue, stopValue);

                textBoxResult.Text = "";
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    string str = string.Format("|{0,5:d}     |  {1,6:f2}  |", startValue, res[i]);
                    textBoxResult.AppendText(str + Environment.NewLine);
                    startValue++;
                }
                textBoxResult.AppendText("+----------+----------+");
            }

            catch
            {
                MessageBox.Show("Введены неверные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПКТб-24-1 Мышакин Данил", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
