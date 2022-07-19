using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace access_array_from_another_form
{
    public partial class CustomForm : Form
    {
        public CustomForm()
        {
            InitializeComponent();
        }
        // These should all be private
        // See naming conventions: https://stackoverflow.com/a/17937309/5438626
        // Set up visual studio to do this automatically: https://ardalis.com/configure-visual-studio-to-name-private-fields-with-underscore/
        private string _normalValue;
        private string _presentValue;
        private int _presentArray = 0;
        private string[] _pValue = new string[50];//public array
        private string[] _nValue = new string[50];//public array

        private void cstmsvbtn_Click(object sender, EventArgs e)
        {
            _presentValue = $"{cstmtst1.Text}_PV"; //concatinate '_PV'
            _normalValue = $"{cstmtst1.Text}_NV"; //concatinate '_NV'
            if ((_presentArray < _pValue.Length) && (_presentArray < _nValue.Length))
            {
                _pValue[_presentArray] = _presentValue;
                _nValue[_presentArray] = _normalValue;
                _presentArray++;
            }
            else MessageBox.Show("Array is Full");
            Text = $"Custom: Count={_presentArray}";
            cstmtst1.Text = $"Hello {_presentArray + 1}";
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        internal void ArraysRequested(object sender, ArrayRequestEventArgs e)
        {
            e.Count = _presentArray;
            e.NValue = _nValue;
            e.PValue = _pValue;
        }
    }
}
