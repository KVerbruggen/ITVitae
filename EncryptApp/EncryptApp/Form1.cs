﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.tbInput.Focus();
            this.tbInput.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            cbEncryptionAlgorithms.Width = tbInput.Width - 56;
            tbKey.Width = tbInput.Width - 158;
        }
    }
}
