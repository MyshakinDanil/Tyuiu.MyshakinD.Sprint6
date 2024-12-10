using Tyuiu.MyshakinD.Sprint6.Task6.V5.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task6.V5 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;

        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonUploadFile_Click(object sender, EventArgs e)
        {
            openFileDialogChooseFile.ShowDialog();
            openFilePath = openFileDialogChooseFile.FileName;
            textBoxInputData.Text = File.ReadAllText(openFilePath);
            groupBoxInput.Text = groupBoxInput.Text + " " + openFileDialogChooseFile.FileName;
            buttonGetResult.Enabled = true;
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            textBoxOutputData.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.ShowDialog();
        }
    }
}
