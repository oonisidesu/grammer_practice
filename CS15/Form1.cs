﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;

            while(i < 10)
            {
                i++;

                if(i == 3)
                {
                    continue;
                }

                if(i == 5)
                {
                    break;
                }

                MessageBox.Show(i.ToString());
            }

            int a = 100;

            do
            {
                a++;
            } while (a < 10);
            
            MessageBox.Show(a.ToString());

        }
    }
}
