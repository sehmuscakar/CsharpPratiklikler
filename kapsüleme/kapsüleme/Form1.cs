﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kapsüleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.renk = "mavi";
            rb.hiz = 160;
            rb.motor = 1245.56;
            rb.fiyat = 50000;
            rb.durum = 's';
            rb.YIL = -2016;// yeni kulanım yani yil değil YIL 
            rb.MARKASI = "Golf";


            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.durum.ToString();
            label5.Text = rb.fiyat.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKASI;// string zaten bu cevirmeye gerek yok 
            pictureBox1.BackColor = Color.CadetBlue;

        }
    }
}
