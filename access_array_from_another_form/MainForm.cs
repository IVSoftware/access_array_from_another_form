using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace access_array_from_another_form
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _printForm.ArrayRequest += _customForm.ArraysRequested;
        }
        private CustomForm _customForm = new CustomForm();
        private PrintForm _printForm = new PrintForm();

        // In MainForm.Designer.cs
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                _customForm.Dispose();
            }
            base.Dispose(disposing);
        }

        private void buttonShowCustom_Click(object sender, EventArgs e)
        {
            _customForm.ShowDialog(owner: this);
        }

        private void buttonShowPrint_Click(object sender, EventArgs e)
        {
            _printForm.ShowDialog(owner: this);
        }
    }
}
