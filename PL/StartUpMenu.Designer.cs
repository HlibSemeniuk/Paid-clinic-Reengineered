namespace PL
{
    partial class StartUpMenu
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
            button_SignIN = new Button();
            textBox_Name = new TextBox();
            textBox_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button_SignIN
            // 
            button_SignIN.Location = new Point(181, 101);
            button_SignIN.Name = "button_SignIN";
            button_SignIN.Size = new Size(75, 23);
            button_SignIN.TabIndex = 0;
            button_SignIN.Text = "Увійти";
            button_SignIN.UseVisualStyleBackColor = true;
            button_SignIN.Click += button_SignIN_Click;
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(120, 32);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(216, 23);
            textBox_Name.TabIndex = 1;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(120, 61);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.Size = new Size(216, 23);
            textBox_Password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 35);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 3;
            label1.Text = "Ім'я та прізвище:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 64);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль:";
            // 
            // StartUpMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 133);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_Name);
            Controls.Add(button_SignIN);
            Name = "StartUpMenu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_SignIN;
        private TextBox textBox_Name;
        private TextBox textBox_Password;
        private Label label1;
        private Label label2;
    }
}