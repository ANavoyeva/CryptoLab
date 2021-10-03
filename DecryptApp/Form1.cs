using EDLibrary;
using System;
using System.Windows.Forms;

namespace DecryptApp
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

            var result = WhitsonsDoubleSquare.Decryption(firstKeyText, secondKeyText, inputString);

            decryptedText.Text = result.result;
            firstMatrix.Text = result.firstMatrix;
            secondMatrix.Text = result.secondMatrix;
        }
    }
}
