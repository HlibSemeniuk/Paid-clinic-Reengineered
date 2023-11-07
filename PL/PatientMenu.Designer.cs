namespace PL
{
    partial class PatientMenu
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(295, 102);
            label1.Name = "label1";
            label1.Size = new Size(121, 25);
            label1.TabIndex = 0;
            label1.Text = "Привітання";
            // 
            // PatientMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Name = "PatientMenu";
            Text = "PatientMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
    }
}