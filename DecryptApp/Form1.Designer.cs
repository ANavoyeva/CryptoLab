
namespace DecryptApp
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
            this.secondMatrix = new System.Windows.Forms.RichTextBox();
            this.firstMatrix = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.decryptedText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.secondKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // secondMatrix
            // 
            this.secondMatrix.Location = new System.Drawing.Point(478, 103);
            this.secondMatrix.Name = "secondMatrix";
            this.secondMatrix.ReadOnly = true;
            this.secondMatrix.Size = new System.Drawing.Size(226, 96);
            this.secondMatrix.TabIndex = 21;
            this.secondMatrix.Text = "";
            // 
            // firstMatrix
            // 
            this.firstMatrix.Location = new System.Drawing.Point(246, 103);
            this.firstMatrix.Name = "firstMatrix";
            this.firstMatrix.ReadOnly = true;
            this.firstMatrix.Size = new System.Drawing.Size(226, 96);
            this.firstMatrix.TabIndex = 20;
            this.firstMatrix.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Decrypted text";
            // 
            // decryptedText
            // 
            this.decryptedText.Location = new System.Drawing.Point(12, 235);
            this.decryptedText.Name = "decryptedText";
            this.decryptedText.ReadOnly = true;
            this.decryptedText.Size = new System.Drawing.Size(226, 96);
            this.decryptedText.TabIndex = 17;
            this.decryptedText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Encrypted text";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(14, 103);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(226, 96);
            this.inputText.TabIndex = 15;
            this.inputText.Text = "";
            this.inputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputText_KeyPress);
            // 
            // secondKey
            // 
            this.secondKey.Location = new System.Drawing.Point(140, 26);
            this.secondKey.Name = "secondKey";
            this.secondKey.Size = new System.Drawing.Size(100, 23);
            this.secondKey.TabIndex = 14;
            this.secondKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondKey_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Second key";
            // 
            // firstKey
            // 
            this.firstKey.Location = new System.Drawing.Point(14, 26);
            this.firstKey.Name = "firstKey";
            this.firstKey.Size = new System.Drawing.Size(100, 23);
            this.firstKey.TabIndex = 12;
            this.firstKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstKey_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "First key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 397);
            this.Controls.Add(this.secondMatrix);
            this.Controls.Add(this.firstMatrix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decryptedText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.secondKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox secondMatrix;
        private System.Windows.Forms.RichTextBox firstMatrix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox decryptedText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.TextBox secondKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstKey;
        private System.Windows.Forms.Label label1;
    }
}

