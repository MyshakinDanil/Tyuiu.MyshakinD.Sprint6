using Tyuiu.MyshakinD.Sprint6.Task0.V6.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task0.V6 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxValueX.Text)));
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПКТб-24-1 Мышакин Данил");
        }
    }
}
