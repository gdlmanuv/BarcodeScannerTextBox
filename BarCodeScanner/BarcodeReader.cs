using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCodeScanner
{
    public partial class BarcodeReader : Form
    {
        private bool _disableKeyboardInput;
        public BarcodeReader()
        {
            InitializeComponent();
            _disableKeyboardInput = false;
            barcodeTextBox1.KeyboardInput(_disableKeyboardInput);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _disableKeyboardInput = !_disableKeyboardInput;
            barcodeTextBox1.KeyboardInput(_disableKeyboardInput);
        }

        private void barcodeTextBox1_EnterKeyPressedOrScanned(object sender, KeyEventArgs e)
        {
            MessageBox.Show(barcodeTextBox1.Text);
        }
    }
}
