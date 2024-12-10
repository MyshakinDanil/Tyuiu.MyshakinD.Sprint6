using System.IO;
using Tyuiu.MyshakinD.Sprint6.Task6.V5;
using Tyuiu.MyshakinD.Sprint6.Task7.V8.Lib;

namespace Tyuiu.MyshakinD.Sprint6.Task7.V8 {
    public partial class FormMain : Form {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        int rows;
        int columns;
        string openFilePath;

        DataService ds = new DataService();

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            string filedata = File.ReadAllText(openFilePath);

            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }

            dataGridViewInputData.ColumnCount = columns;
            dataGridViewInputData.RowCount = rows;
            dataGridViewOutputData.ColumnCount = columns;
            dataGridViewOutputData.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInputData.Columns[i].Width = 25;
                dataGridViewOutputData.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInputData.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonGetResult.Enabled = true;
        }

        private void buttonGetResult_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutputData.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            buttonSaveFile.Enabled = true;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutputData.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutputData.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
