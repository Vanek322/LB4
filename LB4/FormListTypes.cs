﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB4
{
    public partial class FormListTypes : Form
    {
        public FormListTypes()
        {
            InitializeComponent();
        }

        private void BntUpdateType_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddType = new FormAddType();
            formAddType.ShowDialog();
        }
    }
}
