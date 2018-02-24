using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cycle_Data_Project
{
    public partial class Form1 : Form
    {
        Cycle ccl = new Cycle();
        Form2 frm2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Disable textbox1 (select file to load) for file choosing only. 
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the current form.
            // this.Hide();
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the entire application.
            Application.Exit();
        }
    }

    public class Cycle
    {
        public int get_data()
        {
            return 0;
        }
    }
}
