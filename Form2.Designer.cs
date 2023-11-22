namespace RegFormTryCatch
{
    partial class frmFileName
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
            btnOkay = new Button();
            txtFileName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnOkay
            // 
            btnOkay.Location = new Point(102, 108);
            btnOkay.Name = "btnOkay";
            btnOkay.Size = new Size(75, 23);
            btnOkay.TabIndex = 14;
            btnOkay.Text = "Okay";
            btnOkay.UseVisualStyleBackColor = true;
            btnOkay.Click += btnSubmit_Click;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(12, 64);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(265, 23);
            txtFileName.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 16;
            label1.Text = "File Name";
            // 
            // frmFileName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 189);
            Controls.Add(label1);
            Controls.Add(txtFileName);
            Controls.Add(btnOkay);
            Name = "frmFileName";
            Text = "Form2";
            Load += frmConfirm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblstudentno;
        private Label lblname;
        private Label lblprogram;
        private Label lblage;
        private Label lblbirthday;
        private Label lblgender;
        private Label lblcontactno;
        private Button btnOkay;
        private TextBox txtFileName;
        private Label label1;
    }
}