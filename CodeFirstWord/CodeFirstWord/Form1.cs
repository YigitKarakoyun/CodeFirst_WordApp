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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = null;
            TOOLS_SELECT.Get_TBL_WORDS_SORTED();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            var result = TOOLS_SELECT.Get_TBL_WORD(textBox1.Text);
            if (result != null)
            {
                listBox1.Items.Add(result.ToString());
                MessageBox.Show(result.ToString() + " Kelimesi Bulundu");
            }
        }
    }
}
