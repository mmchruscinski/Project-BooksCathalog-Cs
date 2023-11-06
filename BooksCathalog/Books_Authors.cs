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
    public partial class Books_Authors : Form
    {
        public Books_Authors()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Add(object sender, EventArgs e)
        {
            if(auhor.Text.Length> 0) 
            {
                authorlist.Items.Add(authorlist.Text);
            }
            else
            {
                MessageBox.Show("The textbox is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
