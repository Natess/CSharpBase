﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson8
{
    public partial class Task1Form : Form
    {
        public Task1Form()
        {
            InitializeComponent();
        }

        private void Task1Form_Load(object sender, EventArgs e)
        {
            var props = typeof(DateTime).GetProperties();
            tbProperties.Lines = props.Select(x=>x.Name).ToArray();
        }
    }
}