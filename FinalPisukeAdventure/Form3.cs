using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPisukeAdventure
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void show_form2_data(string data)
        {
            label3.Text = data;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 dForm = new Form1();
            dForm.FormClosed += new FormClosedEventHandler(Form1_FormClosed);
            dForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("確定要離開嗎？", "離開", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("掰掰！！！", "結束", MessageBoxButtons.OK);
                Close();
            }
        }
    }
}
