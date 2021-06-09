namespace BarCodeScanner
{
    partial class BarcodeReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.barcodeTextBox1 = new BarCodeScanner.BarcodeTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Disable keyboard input";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // barcodeTextBox1
            // 
            this.barcodeTextBox1.Location = new System.Drawing.Point(7, 12);
            this.barcodeTextBox1.Name = "barcodeTextBox1";
            this.barcodeTextBox1.Size = new System.Drawing.Size(520, 20);
            this.barcodeTextBox1.TabIndex = 0;
            this.barcodeTextBox1.EnterKeyPressedOrScanned += new System.Windows.Forms.KeyEventHandler(this.barcodeTextBox1_EnterKeyPressedOrScanned);
            // 
            // BarcodeReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 141);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.barcodeTextBox1);
            this.Name = "BarcodeReader";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BarcodeTextBox barcodeTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

