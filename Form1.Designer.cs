namespace WindowsForm {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            AddNumber0 = new Button();
            AddNumber2 = new Button();
            AddNumber5 = new Button();
            AddNumber8 = new Button();
            DeleteAll = new Button();
            AddNumber1 = new Button();
            AddNumber4 = new Button();
            AddNumber7 = new Button();
            DeleteEndChar = new Button();
            AddDot = new Button();
            AddNumber3 = new Button();
            AddNumber6 = new Button();
            AddNumber9 = new Button();
            inputValue = new TextBox();
            outputValue = new TextBox();
            inputComboBox = new ComboBox();
            outputComboBox = new ComboBox();
            SuspendLayout();
            // 
            // AddNumber0
            // 
            AddNumber0.Location = new Point(116, 478);
            AddNumber0.Name = "AddNumber0";
            AddNumber0.Size = new Size(79, 58);
            AddNumber0.TabIndex = 13;
            AddNumber0.Text = "0";
            AddNumber0.UseVisualStyleBackColor = true;
            AddNumber0.Click += AddNumber0_Click;
            // 
            // AddNumber2
            // 
            AddNumber2.Location = new Point(116, 414);
            AddNumber2.Name = "AddNumber2";
            AddNumber2.Size = new Size(79, 58);
            AddNumber2.TabIndex = 11;
            AddNumber2.Text = "2";
            AddNumber2.UseVisualStyleBackColor = true;
            AddNumber2.Click += AddNumber2_Click;
            // 
            // AddNumber5
            // 
            AddNumber5.Location = new Point(116, 350);
            AddNumber5.Name = "AddNumber5";
            AddNumber5.Size = new Size(79, 58);
            AddNumber5.TabIndex = 8;
            AddNumber5.Text = "5";
            AddNumber5.UseVisualStyleBackColor = true;
            AddNumber5.Click += AddNumber5_Click;
            // 
            // AddNumber8
            // 
            AddNumber8.Location = new Point(116, 286);
            AddNumber8.Name = "AddNumber8";
            AddNumber8.Size = new Size(79, 58);
            AddNumber8.TabIndex = 5;
            AddNumber8.Text = "8";
            AddNumber8.UseVisualStyleBackColor = true;
            AddNumber8.Click += AddNumber8_Click;
            // 
            // DeleteAll
            // 
            DeleteAll.Location = new Point(116, 214);
            DeleteAll.Name = "DeleteAll";
            DeleteAll.Size = new Size(79, 58);
            DeleteAll.TabIndex = 2;
            DeleteAll.Text = "CE";
            DeleteAll.UseVisualStyleBackColor = true;
            DeleteAll.Click += DeleteAll_Click;
            // 
            // AddNumber1
            // 
            AddNumber1.Location = new Point(12, 414);
            AddNumber1.Name = "AddNumber1";
            AddNumber1.Size = new Size(79, 58);
            AddNumber1.TabIndex = 10;
            AddNumber1.Text = "1";
            AddNumber1.UseVisualStyleBackColor = true;
            AddNumber1.Click += AddNumber1_Click_1;
            // 
            // AddNumber4
            // 
            AddNumber4.Location = new Point(12, 350);
            AddNumber4.Name = "AddNumber4";
            AddNumber4.Size = new Size(79, 58);
            AddNumber4.TabIndex = 7;
            AddNumber4.Text = "4";
            AddNumber4.UseVisualStyleBackColor = true;
            AddNumber4.Click += AddNumber4_Click;
            // 
            // AddNumber7
            // 
            AddNumber7.Location = new Point(12, 286);
            AddNumber7.Name = "AddNumber7";
            AddNumber7.Size = new Size(79, 58);
            AddNumber7.TabIndex = 4;
            AddNumber7.Text = "7";
            AddNumber7.UseVisualStyleBackColor = true;
            AddNumber7.Click += AddNumber7_Click;
            // 
            // DeleteEndChar
            // 
            DeleteEndChar.BackColor = SystemColors.Control;
            DeleteEndChar.BackgroundImage = Properties.Resources.delete_315;
            DeleteEndChar.BackgroundImageLayout = ImageLayout.Zoom;
            DeleteEndChar.Location = new Point(219, 214);
            DeleteEndChar.Name = "DeleteEndChar";
            DeleteEndChar.Size = new Size(79, 58);
            DeleteEndChar.TabIndex = 3;
            DeleteEndChar.TextImageRelation = TextImageRelation.TextAboveImage;
            DeleteEndChar.UseVisualStyleBackColor = false;
            DeleteEndChar.Click += DeleteEndChar_Click;
            // 
            // AddDot
            // 
            AddDot.Location = new Point(219, 478);
            AddDot.Name = "AddDot";
            AddDot.Size = new Size(79, 58);
            AddDot.TabIndex = 14;
            AddDot.Text = ".";
            AddDot.UseVisualStyleBackColor = true;
            AddDot.Click += AddDot_Click;
            // 
            // AddNumber3
            // 
            AddNumber3.Location = new Point(219, 414);
            AddNumber3.Name = "AddNumber3";
            AddNumber3.Size = new Size(79, 58);
            AddNumber3.TabIndex = 12;
            AddNumber3.Text = "3";
            AddNumber3.UseVisualStyleBackColor = true;
            AddNumber3.Click += AddNumber3_Click;
            // 
            // AddNumber6
            // 
            AddNumber6.Location = new Point(219, 350);
            AddNumber6.Name = "AddNumber6";
            AddNumber6.Size = new Size(79, 58);
            AddNumber6.TabIndex = 9;
            AddNumber6.Text = "6";
            AddNumber6.UseVisualStyleBackColor = true;
            AddNumber6.Click += AddNumber6_Click;
            // 
            // AddNumber9
            // 
            AddNumber9.Location = new Point(219, 286);
            AddNumber9.Name = "AddNumber9";
            AddNumber9.Size = new Size(79, 58);
            AddNumber9.TabIndex = 6;
            AddNumber9.Text = "9";
            AddNumber9.UseVisualStyleBackColor = true;
            AddNumber9.Click += AddNumber9_Click;
            // 
            // inputValue
            // 
            inputValue.Location = new Point(12, 89);
            inputValue.Name = "inputValue";
            inputValue.Size = new Size(286, 27);
            inputValue.TabIndex = 0;
            inputValue.TextChanged += inputValue_TextChanged;
            // 
            // outputValue
            // 
            outputValue.BackColor = SystemColors.HighlightText;
            outputValue.Enabled = false;
            outputValue.Location = new Point(12, 161);
            outputValue.Name = "outputValue";
            outputValue.Size = new Size(286, 27);
            outputValue.TabIndex = 1;
            // 
            // inputComboBox
            // 
            inputComboBox.BackColor = SystemColors.Control;
            inputComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            inputComboBox.FlatStyle = FlatStyle.Flat;
            inputComboBox.ForeColor = Color.Black;
            inputComboBox.FormattingEnabled = true;
            inputComboBox.Location = new Point(12, 55);
            inputComboBox.Name = "inputComboBox";
            inputComboBox.Size = new Size(151, 28);
            inputComboBox.TabIndex = 15;
            inputComboBox.SelectedIndexChanged += inputComboBox_SelectedIndexChanged;
            // 
            // outputComboBox
            // 
            outputComboBox.BackColor = SystemColors.Control;
            outputComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            outputComboBox.FlatStyle = FlatStyle.Flat;
            outputComboBox.ForeColor = Color.Black;
            outputComboBox.FormattingEnabled = true;
            outputComboBox.Location = new Point(12, 127);
            outputComboBox.Name = "outputComboBox";
            outputComboBox.Size = new Size(151, 28);
            outputComboBox.TabIndex = 16;
            outputComboBox.SelectedIndexChanged += outputComboBox_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 551);
            Controls.Add(outputComboBox);
            Controls.Add(inputComboBox);
            Controls.Add(outputValue);
            Controls.Add(inputValue);
            Controls.Add(AddDot);
            Controls.Add(AddNumber3);
            Controls.Add(AddNumber6);
            Controls.Add(AddNumber9);
            Controls.Add(DeleteEndChar);
            Controls.Add(AddNumber1);
            Controls.Add(AddNumber4);
            Controls.Add(AddNumber7);
            Controls.Add(AddNumber0);
            Controls.Add(AddNumber2);
            Controls.Add(AddNumber5);
            Controls.Add(AddNumber8);
            Controls.Add(DeleteAll);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //private Label label1;
        private Button AddNumber0;
        private Button AddNumber2;
        private Button AddNumber5;
        private Button AddNumber8;
        private Button DeleteAll;
        private Button AddNumber1;
        private Button AddNumber4;
        private Button AddNumber7;
        private Button DeleteEndChar;
        private Button AddDot;
        private Button AddNumber3;
        private Button AddNumber6;
        private Button AddNumber9;
        private TextBox inputValue;
        private TextBox outputValue;
        private ComboBox inputComboBox;
        private ComboBox outputComboBox;
    }
}