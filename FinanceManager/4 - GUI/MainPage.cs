﻿using FinanceManager._4___GUI;
using FinanceManager.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManager
{
    public partial class Form1 : Form
    {
        private PersonRegister PersonRegister = null;
        private FinanceTypesRegister FinanceTypesRegister = null;
        private Finances Finances = null;
        public Form1()
        {
            InitializeComponent();
        }

        public void DisposeOfAny()
        {
            if (PersonRegister != null)
                PersonRegister.Dispose();

            if (FinanceTypesRegister != null)
                FinanceTypesRegister.Dispose();

            if (Finances != null)
                Finances.Dispose();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            DisposeOfAny();
            PersonRegister = new PersonRegister();
            this.MainPanel.Controls.Add(PersonRegister);
        }

        private void btnFinanceTypes_Click(object sender, EventArgs e)
        {
            DisposeOfAny();
            FinanceTypesRegister = new FinanceTypesRegister();
            this.MainPanel.Controls.Add(FinanceTypesRegister);
        }

        private void btnFinances_Click(object sender, EventArgs e)
        {
            DisposeOfAny();
            Finances = new Finances();
            this.MainPanel.Controls.Add(Finances);
        }

    }
}
