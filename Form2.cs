﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generatorHasel
{
    public partial class Form2 : Form
    {
        public Form2(string generatedPass)
        {
            InitializeComponent();
            textBox1.Text = generatedPass;
        }

        //public void think (List<Pass> passList)
        //{
        //    
        //}
    }
}
