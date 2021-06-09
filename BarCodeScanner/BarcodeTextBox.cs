using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCodeScanner
{
    public class BarcodeTextBox : TextBox
    {
        private DateTime _keyDownTime;
        private bool _keyboardInputDisabled;

        public event KeyEventHandler EnterKeyPressedOrScanned;
        
        public BarcodeTextBox()
        {
            KeyDown += BarcodeTextBox_KeyDown;
            KeyUp += BarcodeTextBox_KeyUp;
        }

        public void KeyboardInput(bool disable)
        {
            _keyboardInputDisabled = disable;
        }

        private void BarcodeTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (_keyboardInputDisabled)
            {
                if ((DateTime.Now - _keyDownTime).Milliseconds < 17)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        EnterKeyPressedOrScanned?.Invoke(sender, e);
                    }
                }
                else
                {
                    Text = string.Empty;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    EnterKeyPressedOrScanned?.Invoke(sender, e);
                }
            }            
        }

        private void BarcodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            _keyDownTime = DateTime.Now;
        }
    }
}
