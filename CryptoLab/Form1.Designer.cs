
namespace CryptoLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.firstKey = new System.Windows.Forms.TextBox();
            this.secondKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.encryptedText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.firstMatrix = new System.Windows.Forms.RichTextBox();
            this.secondMatrix = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First key";
            // 
            // firstKey
            // 
            this.firstKey.Location = new System.Drawing.Point(12, 36);
            this.firstKey.Name = "firstKey";
            this.firstKey.Size = new System.Drawing.Size(100, 23);
            this.firstKey.TabIndex = 1;
            // 
            // secondKey
            // 
            this.secondKey.Location = new System.Drawing.Point(138, 36);
            this.secondKey.Name = "secondKey";
            this.secondKey.Size = new System.Drawing.Size(100, 23);
            this.secondKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Second key";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(12, 113);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(226, 96);
            this.inputText.TabIndex = 4;
            this.inputText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Encrypted text";
            // 
            // encryptedText
            // 
            this.encryptedText.Location = new System.Drawing.Point(10, 245);
            this.encryptedText.Name = "encryptedText";
            this.encryptedText.Size = new System.Drawing.Size(226, 96);
            this.encryptedText.TabIndex = 6;
            this.encryptedText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstMatrix
            // 
            this.firstMatrix.Location = new System.Drawing.Point(244, 113);
            this.firstMatrix.Name = "firstMatrix";
            this.firstMatrix.Size = new System.Drawing.Size(226, 96);
            this.firstMatrix.TabIndex = 9;
            this.firstMatrix.Text = "";
            // 
            // secondMatrix
            // 
            this.secondMatrix.Location = new System.Drawing.Point(476, 113);
            this.secondMatrix.Name = "secondMatrix";
            this.secondMatrix.Size = new System.Drawing.Size(226, 96);
            this.secondMatrix.TabIndex = 10;
            this.secondMatrix.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 399);
            this.Controls.Add(this.secondMatrix);
            this.Controls.Add(this.firstMatrix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.encryptedText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.secondKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstKey;
        private System.Windows.Forms.TextBox secondKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox encryptedText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox firstMatrix;
        private System.Windows.Forms.RichTextBox secondMatrix;
    }
}

