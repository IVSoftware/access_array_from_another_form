using System;
using System.Linq;
using System.Windows.Forms;

namespace access_array_from_another_form
{
    public partial class PrintForm : Form
    {
        public PrintForm()
        {
            InitializeComponent();
        }
        public event ArrayRequestEventHandler ArrayRequest;
        protected virtual void OnArrayRequest(ArrayRequestEventArgs e)
        {
            ArrayRequest?.Invoke(this, e);
        }
        private void buttonShowArray_Click(object sender, EventArgs e)
        {
            ArrayRequestEventArgs req = new ArrayRequestEventArgs();
            OnArrayRequest(req);
            if(req.Count == 0)
            {
                MessageBox.Show("Invalid Request");
            }
            else
            {
                String[] allValues =
                    Enumerable.Range(0, req.Count)
                    .Select(index => $"{req.NValue[index]} | {req.PValue[index]}")
                    .ToArray();
                MessageBox.Show(
                    text: string.Join(Environment.NewLine, allValues),
                    caption: "All Values"
                );
            }
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public delegate void ArrayRequestEventHandler(Object sender, ArrayRequestEventArgs e);
    public class ArrayRequestEventArgs : EventArgs
    {
        public int Count { get; set; }
        public string[] PValue { get; set; }
        public string[] NValue { get; set; }
    }
}
