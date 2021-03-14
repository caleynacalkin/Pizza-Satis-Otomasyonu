using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PizzaDukkan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        private void btn_yonetici_Click(object sender, EventArgs e)
        {
            Yonetici yeniform = new Yonetici();
            yeniform.Show();
            this.Hide();
        }

        private void btn_Siparis_Click(object sender, EventArgs e)
        {
            Siparis yeniform = new Siparis();
            yeniform.Show();
            this.Hide();
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
