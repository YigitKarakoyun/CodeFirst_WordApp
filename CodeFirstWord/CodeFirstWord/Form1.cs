using CodeFirstWord.Tools;
using CodeFirstWord.Entity;
using CodeFirstWord.Model;
using System;
using System.Windows.Forms;

namespace CodeFirstWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WORD_ENTITIES db = new WORD_ENTITIES();
        private void button1_Click(object sender, EventArgs e)
        {
            //TOOLS.Add_TBL_WORD_WITH_CLEANSTRING(textBox1.Text);
            //AllWords.SetDosyaOku();
            var result = TOOLS_SELECT.Get_TBL_WORD_SORTED(textBox1.Text);
            MessageBox.Show(result+"");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = TOOLS_SELECT.Get_TBL_WORDS_SORTED();
        }
    }
}
