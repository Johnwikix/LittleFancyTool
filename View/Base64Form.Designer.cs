namespace CryptoTool.View
{
    partial class Base64Form
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
            encryptBtn = new Button();
            decryptBtn = new Button();
            inputTextBox = new TextBox();
            outputTextBox = new TextBox();
            inputLabel = new Label();
            outputLabel = new Label();
            SuspendLayout();
            // 
            // encryptBtn
            // 
            encryptBtn.Location = new Point(642, 107);
            encryptBtn.Name = "encryptBtn";
            encryptBtn.Size = new Size(112, 34);
            encryptBtn.TabIndex = 0;
            encryptBtn.Text = "加密>>";
            encryptBtn.UseVisualStyleBackColor = true;
            encryptBtn.Click += encryptButton_Click;
            // 
            // decryptBtn
            // 
            decryptBtn.Location = new Point(642, 162);
            decryptBtn.Name = "decryptBtn";
            decryptBtn.Size = new Size(112, 34);
            decryptBtn.TabIndex = 1;
            decryptBtn.Text = "解密<<";
            decryptBtn.UseVisualStyleBackColor = true;
            decryptBtn.Click += decryptButton_Click;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(97, 107);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ScrollBars = ScrollBars.Vertical;
            inputTextBox.Size = new Size(501, 237);
            inputTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(818, 109);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(473, 235);
            outputTextBox.TabIndex = 3;
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(98, 61);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(64, 24);
            inputLabel.TabIndex = 4;
            inputLabel.Text = "输入框";
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(818, 61);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(64, 24);
            outputLabel.TabIndex = 5;
            outputLabel.Text = "输出框";
            // 
            // Base64Form
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 744);
            Controls.Add(outputLabel);
            Controls.Add(inputLabel);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(decryptBtn);
            Controls.Add(encryptBtn);
            Name = "Base64Form";
            Text = "Base64Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encryptBtn;
        private Button decryptBtn;
        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Label inputLabel;
        private Label outputLabel;
    }
}