namespace _16Lab2 {
    public partial class frmTextAnalyzerGUI : Form {
        public frmTextAnalyzerGUI() {
            InitializeComponent();
        }

        private void frmTextAnalyzerGUI_Load(object sender, EventArgs e) {

            lblAnalysis.Text = "Analysis" +
                "\nNumber of Sentences: 0" +
                "\nNumber of Words: 0" +
                "\nNumber of Unique Words: 0";
        }

        private void btnAnalyze_Click(object sender, EventArgs e) {

            listView1.Items.Clear();

            string text = textBox1.Text;

            TextAnaylsis test = new TextAnaylsis(text);

            int numSentences = test.NumOfSentences;
            int numWords = test.NumOfWords;
            int numUnqiueWords = test.NumOfUniqueWords;
            Dictionary<string, int> words = test.Words;

            lblAnalysis.Text = $"Num of Sentences: {numSentences}" +
                $"\nNum of Words: {numWords}" +
                $"\n Num of UnquieWords: {numUnqiueWords}";

            foreach (var item in words) {

                ListViewItem listViewItem = new ListViewItem(item.Key);
                listViewItem.SubItems.Add(item.Value.ToString());
                listView1.Items.Add(listViewItem);

            }

            words.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void lblPurpose_Click(object sender, EventArgs e) {

        }
    }
}