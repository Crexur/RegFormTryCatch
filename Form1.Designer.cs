namespace RegFormTryCatch
{
    partial class frmRegistration
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnregister = new Button();
            txtstudentno = new TextBox();
            txtcontactno = new TextBox();
            txtmiddleinitial = new TextBox();
            txtfirstname = new TextBox();
            txtage = new TextBox();
            txtlastname = new TextBox();
            cbprogram = new ComboBox();
            cbgender = new ComboBox();
            datepickerbirthday = new DateTimePicker();
            btnRecord = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(132, 30);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 79);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "Student No";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 121);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 157);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 3;
            label4.Text = "Age";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 201);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 79);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 5;
            label6.Text = "Program";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 113);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 6;
            label7.Text = "First Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(436, 108);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 7;
            label8.Text = "M.I";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(260, 134);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 8;
            label9.Text = "Gender";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(256, 166);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 9;
            label10.Text = "Contact No";
            // 
            // btnregister
            // 
            btnregister.Location = new Point(218, 241);
            btnregister.Name = "btnregister";
            btnregister.Size = new Size(75, 23);
            btnregister.TabIndex = 10;
            btnregister.Text = "Register";
            btnregister.UseVisualStyleBackColor = true;
            btnregister.Click += btnregister_Click;
            // 
            // txtstudentno
            // 
            txtstudentno.Location = new Point(103, 76);
            txtstudentno.Name = "txtstudentno";
            txtstudentno.Size = new Size(123, 23);
            txtstudentno.TabIndex = 11;
            // 
            // txtcontactno
            // 
            txtcontactno.Location = new Point(322, 161);
            txtcontactno.Name = "txtcontactno";
            txtcontactno.Size = new Size(108, 23);
            txtcontactno.TabIndex = 12;
            // 
            // txtmiddleinitial
            // 
            txtmiddleinitial.Location = new Point(466, 105);
            txtmiddleinitial.Name = "txtmiddleinitial";
            txtmiddleinitial.Size = new Size(48, 23);
            txtmiddleinitial.TabIndex = 14;
            // 
            // txtfirstname
            // 
            txtfirstname.Location = new Point(319, 105);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(111, 23);
            txtfirstname.TabIndex = 15;
            // 
            // txtage
            // 
            txtage.Location = new Point(64, 154);
            txtage.Name = "txtage";
            txtage.Size = new Size(162, 23);
            txtage.TabIndex = 16;
            // 
            // txtlastname
            // 
            txtlastname.Location = new Point(103, 116);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(123, 23);
            txtlastname.TabIndex = 17;
            // 
            // cbprogram
            // 
            cbprogram.FormattingEnabled = true;
            cbprogram.Location = new Point(319, 76);
            cbprogram.Name = "cbprogram";
            cbprogram.Size = new Size(155, 23);
            cbprogram.TabIndex = 18;
            // 
            // cbgender
            // 
            cbgender.FormattingEnabled = true;
            cbgender.Items.AddRange(new object[] { "Male ", "Female", "Other..." });
            cbgender.Location = new Point(311, 134);
            cbgender.Name = "cbgender";
            cbgender.Size = new Size(144, 23);
            cbgender.TabIndex = 19;
            // 
            // datepickerbirthday
            // 
            datepickerbirthday.Location = new Point(178, 195);
            datepickerbirthday.Name = "datepickerbirthday";
            datepickerbirthday.Size = new Size(200, 23);
            datepickerbirthday.TabIndex = 20;
            // 
            // btnRecord
            // 
            btnRecord.Location = new Point(413, 241);
            btnRecord.Name = "btnRecord";
            btnRecord.Size = new Size(75, 23);
            btnRecord.TabIndex = 21;
            btnRecord.Text = "Records";
            btnRecord.UseVisualStyleBackColor = true;
            btnRecord.Click += btnRecord_Click;
            // 
            // frmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 299);
            Controls.Add(btnRecord);
            Controls.Add(datepickerbirthday);
            Controls.Add(cbgender);
            Controls.Add(cbprogram);
            Controls.Add(txtlastname);
            Controls.Add(txtage);
            Controls.Add(txtfirstname);
            Controls.Add(txtmiddleinitial);
            Controls.Add(txtcontactno);
            Controls.Add(txtstudentno);
            Controls.Add(btnregister);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegistration";
            Text = "frmRegistration";
            Load += frmRegistration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnregister;
        private TextBox txtstudentno;
        private TextBox txtcontactno;
        private TextBox txtmiddleinitial;
        private TextBox txtfirstname;
        private TextBox txtage;
        private TextBox txtlastname;
        private ComboBox cbprogram;
        private ComboBox cbgender;
        private DateTimePicker datepickerbirthday;
        private Button btnRecord;
    }
}