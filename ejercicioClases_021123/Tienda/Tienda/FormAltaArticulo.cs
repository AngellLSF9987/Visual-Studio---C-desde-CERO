﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda
{
    public partial class FormAltaArticulo : Form
    {
        public FormAltaArticulo()
        {
            InitializeComponent();
        }

        private void FormAltaArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e) => Close();
    }
}