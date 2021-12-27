using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitap3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        public Stack <string> yigit = new Stack <string>();
        public Queue <string> kuyruk = new Queue <string>();

        int counter =0  ;
        int counter2 = 0;
        decimal bsuresi = 0;


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.TextLength != 0)
            {

                
                if (numericUpDown1.Value > counter)
                {
                    yigit.Push(textBox1.Text);
                    listBox1.Items.Clear();
                    foreach (string i in yigit)
                    {
                        listBox1.Items.Add(i);

                    }
                    counter = listBox1.Items.Count;
                    label7.Text = ("Kitap Sayısı : " + counter);
                }
                else { MessageBox.Show("Max boyuta ulaşıldı!! Lütfen boyut artırımı yapın."); }

            }
        else { MessageBox.Show("Lütfen kitap adı girin!!"); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            if (counter != 0)
            {
                string feedback;
                feedback = yigit.Pop().ToString();
                numericUpDown1.Minimum = listBox1.Items.Count;
                listBox1.Items.Clear();
                foreach (string i in yigit)
                    listBox1.Items.Add(i);
                textBox2.Text = feedback;
                counter--;
                label7.Text = ("Kitap Sayısı : " + counter);
            }
            else { MessageBox.Show("Stack boş"); }
            


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            numericUpDown1.Minimum = listBox1.Items.Count;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal isuresi = 0;
            

            if (textBox3.TextLength != 0)
            {
                if (numericUpDown3.Value > counter2)
                {
                    isuresi = numericUpDown2.Value;
                    
                    kuyruk.Enqueue(textBox3.Text + "-" + isuresi + "-" + bsuresi);
                    bsuresi += isuresi;
                    numericUpDown2.Value = 0;
                    listBox2.Items.Clear();
                    foreach (string i in kuyruk)
                    { 
                        listBox2.Items.Add(i);
                    }

                    counter2 = listBox2.Items.Count;
                    label15.Text = ("Kişi Sayısı : " + counter2);
                }
                else { MessageBox.Show("Max boyuta ulaşıldı!! Lütfen boyut artırımı yapın."); }

            }
            else { MessageBox.Show("Lütfen kitap adı girin!!"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (counter2 != 0)
            {
                string feedback2;
                feedback2 = kuyruk.Dequeue().ToString();
                numericUpDown3.Minimum = listBox2.Items.Count;
                listBox2.Items.Clear();
                foreach (string i in kuyruk)
                    listBox2.Items.Add(i);
                textBox4.Text = feedback2;
                counter2--;
                label15.Text = ("Kişi Sayısı : " + counter2);
            }
            else { MessageBox.Show("Stack boş"); }
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown3.Minimum = listBox2.Items.Count;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
