﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.FirstName = "大石";
            customer.LastName = "大二郎";
            MessageBox.Show(customer.GetFullName());

            Customer customer2 = new Customer();
            customer2.FirstName = "石";
            customer2.LastName = "二郎";
            MessageBox.Show(customer2.GetFullName());
        }
    }
}
