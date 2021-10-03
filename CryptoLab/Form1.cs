using EDLibrary;
using System;
using System.Windows.Forms;

namespace CryptoLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var firstKeyText = firstKey.Text;
            var secondKeyText = secondKey.Text;

            var inputString = inputText.Text;

            var result = WhitsonsDoubleSquare.Encryption(firstKeyText,secondKeyText, inputString);

            encryptedText.Text = result.result;
            firstMatrix.Text = result.firstMatrix;
            secondMatrix.Text = result.secondMatrix;
        }
    }
}
