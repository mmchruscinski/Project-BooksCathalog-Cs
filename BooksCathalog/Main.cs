using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksCathalog
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Go_Books(object sender, EventArgs e)
        {
            this.Hide();
            new Books_Menu().ShowDialog(); 
        }

        private void Go_Films(object sender, EventArgs e)
        {

        }

        private void Go_Concerts(object sender, EventArgs e)
        {

        }

        private void Go_Museums(object sender, EventArgs e)
        {

        }
    }
}
