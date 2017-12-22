using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] budget = { 15, 1 };
        private int[] amateur = { 10, 3 };
        private int[] profi = { 2, 19 };
        private int[] d1202 = { 1, 13 };
        private int[] d1202_6 = { 9, 8 };
        private int[] d1206 = { 17, 2 };
        private int[] low = { 18, 4 };
        private int[] middle = { 8, 9 };
        private int[] high = { 1, 10 };
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

         
            textBox2.Text = Convert.ToString(27.0 / 50.0);

            textBox3.Text = Convert.ToString(23.0 / 50.0);

           
            textBox4.Text = Convert.ToString(profi[0] / 27.0);
            
            textBox5.Text = Convert.ToString(profi[1] / 23.0);

           
            textBox6.Text = Convert.ToString(d1202[0] / 27.0);
            
            textBox7.Text = Convert.ToString(d1202[1] / 23.0);

           
            textBox8.Text = Convert.ToString(high[0] / 27.0);
            
            textBox9.Text = Convert.ToString(high[1] / 23.0);

            textBox10.Text = Convert.ToString(profi[0] / 27.0 * d1202[0] / 27.0 * high[0] / 27.0);
            textBox11.Text = Convert.ToString(profi[1] / 23.0 * d1202[1] / 23.0 * high[1] / 23.0);

            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox2.Text) / (Convert.ToDouble(textBox10.Text)* Convert.ToDouble(textBox2.Text)
                + Convert.ToDouble(textBox11.Text) * Convert.ToDouble(textBox3.Text)));


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
