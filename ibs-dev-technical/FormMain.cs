namespace ibs_dev_technical
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedFilePath = "";
            string selectedFileName = "";

            OpenFileDialog openFileDialog = new OpenFileDialog();

            //default directory: user/mydocuments
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                selectedFileName = Path.GetFileName(openFileDialog.FileName);

                textFilePath.Text = selectedFilePath;
                textFileName.Text = selectedFileName;
            }

        }
    }
}
