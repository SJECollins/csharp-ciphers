namespace Ciphers
{
    partial class CipherForm
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
            enterText = new Label();
            userInputBox = new TextBox();
            decryptButton = new Button();
            label1 = new Label();
            binarylabel = new Label();
            label3 = new Label();
            label4 = new Label();
            caesarOutput = new Label();
            binaryOutput = new Label();
            morseOutput = new Label();
            keyboardOutput = new Label();
            encryptButton = new Button();
            resetButton = new Button();
            saveButton = new Button();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            label8 = new Label();
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // enterText
            // 
            enterText.AutoSize = true;
            enterText.Font = new Font("Segoe UI", 14F);
            enterText.Location = new Point(49, 27);
            enterText.Name = "enterText";
            enterText.Size = new Size(96, 25);
            enterText.TabIndex = 0;
            enterText.Text = "Enter text:";
            // 
            // userInputBox
            // 
            userInputBox.Font = new Font("Segoe UI", 12F);
            userInputBox.Location = new Point(208, 27);
            userInputBox.Name = "userInputBox";
            userInputBox.Size = new Size(400, 29);
            userInputBox.TabIndex = 1;
            // 
            // decryptButton
            // 
            decryptButton.Cursor = Cursors.Hand;
            decryptButton.FlatStyle = FlatStyle.Popup;
            decryptButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            decryptButton.Location = new Point(533, 80);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(75, 23);
            decryptButton.TabIndex = 2;
            decryptButton.Text = "Decrypt";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += DecryptButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(49, 137);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 3;
            label1.Text = "Caesar:";
            // 
            // binarylabel
            // 
            binarylabel.AutoSize = true;
            binarylabel.Font = new Font("Segoe UI", 14F);
            binarylabel.Location = new Point(49, 395);
            binarylabel.Name = "binarylabel";
            binarylabel.Size = new Size(69, 25);
            binarylabel.TabIndex = 4;
            binarylabel.Text = "Binary:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(49, 310);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 5;
            label3.Text = "Morse:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(49, 225);
            label4.Name = "label4";
            label4.Size = new Size(96, 25);
            label4.TabIndex = 6;
            label4.Text = "Keyboard:";
            // 
            // caesarOutput
            // 
            caesarOutput.AutoSize = true;
            caesarOutput.BorderStyle = BorderStyle.Fixed3D;
            caesarOutput.Font = new Font("Segoe UI", 12F);
            caesarOutput.Location = new Point(208, 141);
            caesarOutput.MaximumSize = new Size(400, 69);
            caesarOutput.MinimumSize = new Size(400, 23);
            caesarOutput.Name = "caesarOutput";
            caesarOutput.Size = new Size(400, 23);
            caesarOutput.TabIndex = 7;
            // 
            // binaryOutput
            // 
            binaryOutput.AutoSize = true;
            binaryOutput.BorderStyle = BorderStyle.Fixed3D;
            binaryOutput.Font = new Font("Segoe UI", 12F);
            binaryOutput.Location = new Point(208, 395);
            binaryOutput.MaximumSize = new Size(400, 400);
            binaryOutput.MinimumSize = new Size(400, 23);
            binaryOutput.Name = "binaryOutput";
            binaryOutput.Size = new Size(400, 23);
            binaryOutput.TabIndex = 8;
            // 
            // morseOutput
            // 
            morseOutput.AutoSize = true;
            morseOutput.BorderStyle = BorderStyle.Fixed3D;
            morseOutput.Font = new Font("Segoe UI", 12F);
            morseOutput.Location = new Point(208, 310);
            morseOutput.MaximumSize = new Size(400, 69);
            morseOutput.MinimumSize = new Size(400, 23);
            morseOutput.Name = "morseOutput";
            morseOutput.Size = new Size(400, 23);
            morseOutput.TabIndex = 9;
            // 
            // keyboardOutput
            // 
            keyboardOutput.AutoSize = true;
            keyboardOutput.BorderStyle = BorderStyle.Fixed3D;
            keyboardOutput.Font = new Font("Segoe UI", 12F);
            keyboardOutput.Location = new Point(208, 225);
            keyboardOutput.MaximumSize = new Size(400, 69);
            keyboardOutput.MinimumSize = new Size(400, 23);
            keyboardOutput.Name = "keyboardOutput";
            keyboardOutput.Size = new Size(400, 23);
            keyboardOutput.TabIndex = 10;
            // 
            // encryptButton
            // 
            encryptButton.Cursor = Cursors.Hand;
            encryptButton.FlatStyle = FlatStyle.Popup;
            encryptButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            encryptButton.Location = new Point(208, 80);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(75, 23);
            encryptButton.TabIndex = 11;
            encryptButton.Text = "Encrypt";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += EncryptButton_Click;
            // 
            // resetButton
            // 
            resetButton.Cursor = Cursors.Hand;
            resetButton.FlatStyle = FlatStyle.Popup;
            resetButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            resetButton.Location = new Point(208, 510);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 12;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetButton_Click;
            // 
            // saveButton
            // 
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            saveButton.Location = new Point(533, 510);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 13;
            saveButton.Text = "Save File";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(632, 310);
            label6.MaximumSize = new Size(150, 0);
            label6.Name = "label6";
            label6.Size = new Size(126, 15);
            label6.TabIndex = 16;
            label6.Text = "Encrypt: alphanumeric";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(632, 325);
            label7.MaximumSize = new Size(150, 0);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 17;
            label7.Text = "Decrypt: '.' '-' '/'";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(634, 225);
            label2.MaximumSize = new Size(150, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 18;
            label2.Text = "Encrypt: alphanumeric";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(633, 240);
            label8.MaximumSize = new Size(150, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 15);
            label8.TabIndex = 19;
            label8.Text = "Decrypt: alphanumeric";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(632, 141);
            label5.MaximumSize = new Size(150, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 20;
            label5.Text = "Encrypt: alphanumeric";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(633, 156);
            label9.MaximumSize = new Size(150, 0);
            label9.Name = "label9";
            label9.Size = new Size(127, 15);
            label9.TabIndex = 21;
            label9.Text = "Decrypt: alphanumeric";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(632, 395);
            label10.MaximumSize = new Size(150, 0);
            label10.Name = "label10";
            label10.Size = new Size(126, 15);
            label10.TabIndex = 22;
            label10.Text = "Encrypt: alphanumeric";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(632, 410);
            label11.MaximumSize = new Size(150, 0);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 23;
            label11.Text = "Decrypt: binary";

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(saveButton);
            Controls.Add(resetButton);
            Controls.Add(encryptButton);
            Controls.Add(keyboardOutput);
            Controls.Add(morseOutput);
            Controls.Add(binaryOutput);
            Controls.Add(caesarOutput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(binarylabel);
            Controls.Add(label1);
            Controls.Add(decryptButton);
            Controls.Add(userInputBox);
            Controls.Add(enterText);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Cipher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enterText;
        private TextBox userInputBox;
        private Button decryptButton;
        private Label label1;
        private Label binarylabel;
        private Label label3;
        private Label label4;
        private Label caesarOutput;
        private Label binaryOutput;
        private Label morseOutput;
        private Label keyboardOutput;
        private Button encryptButton;
        private Button resetButton;
        private Button saveButton;
        private Label label6;
        private Label label7;
        private Label label2;
        private Label label8;
        private Label label5;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}
