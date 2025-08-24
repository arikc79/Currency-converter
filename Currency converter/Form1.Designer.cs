namespace Currency_converter
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
            button_Conect = new Button();
            buttonDisconect = new Button();
            button_Convert = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox_IPadress = new TextBox();
            comboBox_SelectСurrency_A = new ComboBox();
            comboBox_SelectCurrency_B = new ComboBox();
            label_Conect = new Label();
            SuspendLayout();
            // 
            // button_Conect
            // 
            button_Conect.Location = new Point(12, 122);
            button_Conect.Name = "button_Conect";
            button_Conect.Size = new Size(249, 60);
            button_Conect.TabIndex = 0;
            button_Conect.Text = "Підключити";
            button_Conect.UseVisualStyleBackColor = true;
            button_Conect.Click += button_Conect_Click;
            // 
            // buttonDisconect
            // 
            buttonDisconect.Location = new Point(294, 122);
            buttonDisconect.Name = "buttonDisconect";
            buttonDisconect.Size = new Size(249, 60);
            buttonDisconect.TabIndex = 1;
            buttonDisconect.Text = "Відключити";
            buttonDisconect.UseVisualStyleBackColor = true;
            buttonDisconect.Click += buttonDisconect_Click;
            // 
            // button_Convert
            // 
            button_Convert.Location = new Point(142, 275);
            button_Convert.Name = "button_Convert";
            button_Convert.Size = new Size(249, 46);
            button_Convert.TabIndex = 2;
            button_Convert.Text = "Конвертувати";
            button_Convert.UseVisualStyleBackColor = true;
            button_Convert.Click += button_Convert_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(169, 28);
            label1.TabIndex = 3;
            label1.Text = "Введіть IP адресс:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(188, 336);
            label2.Name = "label2";
            label2.Padding = new Padding(40);
            label2.Size = new Size(128, 136);
            label2.TabIndex = 4;
            label2.Text = "0";
            // 
            // textBox_IPadress
            // 
            textBox_IPadress.Location = new Point(294, 24);
            textBox_IPadress.Name = "textBox_IPadress";
            textBox_IPadress.Size = new Size(249, 31);
            textBox_IPadress.TabIndex = 5;
            // 
            // comboBox_SelectСurrency_A
            // 
            comboBox_SelectСurrency_A.FormattingEnabled = true;
            comboBox_SelectСurrency_A.Items.AddRange(new object[] { "USD", "EURO", "UAH", "GBP" });
            comboBox_SelectСurrency_A.Location = new Point(15, 83);
            comboBox_SelectСurrency_A.Name = "comboBox_SelectСurrency_A";
            comboBox_SelectСurrency_A.Size = new Size(246, 33);
            comboBox_SelectСurrency_A.TabIndex = 6;
            // 
            // comboBox_SelectCurrency_B
            // 
            comboBox_SelectCurrency_B.FormattingEnabled = true;
            comboBox_SelectCurrency_B.Items.AddRange(new object[] { "USD", "EURO", "UAH", "GBP" });
            comboBox_SelectCurrency_B.Location = new Point(294, 83);
            comboBox_SelectCurrency_B.Name = "comboBox_SelectCurrency_B";
            comboBox_SelectCurrency_B.Size = new Size(249, 33);
            comboBox_SelectCurrency_B.TabIndex = 7;
            // 
            // label_Conect
            // 
            label_Conect.AutoSize = true;
            label_Conect.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label_Conect.ForeColor = Color.SpringGreen;
            label_Conect.Location = new Point(173, 197);
            label_Conect.Name = "label_Conect";
            label_Conect.Size = new Size(0, 48);
            label_Conect.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 513);
            Controls.Add(label_Conect);
            Controls.Add(comboBox_SelectCurrency_B);
            Controls.Add(comboBox_SelectСurrency_A);
            Controls.Add(textBox_IPadress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_Convert);
            Controls.Add(buttonDisconect);
            Controls.Add(button_Conect);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Convert";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Conect;
        private Button buttonDisconect;
        private Button button_Convert;
        private Label label1;
        private Label label2;
        private TextBox textBox_IPadress;
        private ComboBox comboBox_SelectСurrency_A;
        private ComboBox comboBox_SelectCurrency_B;
        private Label label_Conect;
    }
}