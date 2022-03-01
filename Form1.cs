using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArraylistOrnekleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList kolA = new ArrayList(); 
        List<int> kolL = new List<int>(); 
        Stopwatch km = new Stopwatch();
        
        int elemanSayisi = 100000;
        private void button1_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < elemanSayisi; i++)
            {
              kolA.Add(i);
            }
            km.Stop();
            label1.Text = "=" +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < elemanSayisi; i++)
            {
            kolL.Add(i);
            }
            km.Stop();
            label2.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            km.Start();
            int toplam = 0;
            for (int i = 0; i < kolA.Count; i++)
            {
            toplam +=(int)kolA[i];
            }
            km.Stop();
            label3.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
       }

        private void button4_Click(object sender, EventArgs e)
        {
            km.Start();
            int toplam = 0;
            for (int i = 0; i < kolL.Count; i++)
            {
                toplam += kolL[i];
            }
            km.Stop();
            label4.Text ="= "+
            
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < elemanSayisi; i++)
            {
            listBox1.Items.Add(kolA[i]);
            }
            km.Stop();
            label5.Text= "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            km.Start();
            for (int i = 0; i < kolL.Count; i++)
            {
            listBox2.Items.Add(kolL[i]);
            }
            km.Stop();
            label6.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            km.Start();
            if(kolA.Contains(9999))
            {
            km.Stop();
            }
            label7.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            km.Start();
            if (kolL.Contains(9999))
            {
                km.Stop();
            }
            label8.Text = "= " +
            km.Elapsed.TotalMilliseconds;
            km.Reset();
        }
    }
}
