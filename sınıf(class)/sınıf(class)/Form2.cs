﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıf_class_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            araba rb2 = new araba();

            rb2.renk = "yeşil";
            rb2.hiz = 140;
            rb2.motor = 1220.36;
            rb2.fiyat = 35850;
            rb2.durum = 'i';

            label1.Text = rb2.renk;
            label2.Text = rb2.hiz.ToString();
            label3.Text = rb2.motor.ToString();
            label4.Text = rb2.durum.ToString();
            label5.Text = rb2.fiyat.ToString();

            pictureBox1.BackColor = Color.LightSeaGreen;
        }
    }
}
