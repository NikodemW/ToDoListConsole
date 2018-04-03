using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dzadanie1.Checked && dzadanie2.Checked && dzadanie3.Checked && dzadanie4.Checked && dzadanie5.Checked)
            {
                label1.Text = ("Dobra robota !");
            }
            else
            {
                MessageBox.Show("Musisz dokończyć zadania z listy zadań codziennych.");
            }
            if(tzadanie1.Checked && tzadanie2.Checked && tzadanie3.Checked && tzadanie4.Checked)
            {
                label2.Text = ("Dobra robota !");
            }
            else
            {
                MessageBox.Show("Musisz dokończyć zadania z listy zadań tygodniowych");
            }
        }

        private void coding_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
