namespace Skills_international
{
    partial class registration
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
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLogOut = new System.Windows.Forms.LinkLabel();
            this.labEmpNO = new System.Windows.Forms.Label();
            this.regNo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.labGender = new System.Windows.Forms.Label();
            this.labDateOfBirth = new System.Windows.Forms.Label();
            this.labLastName = new System.Windows.Forms.Label();
            this.labFirstName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHphone = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labHomePhone = new System.Windows.Forms.Label();
            this.LabMobilePhone = new System.Windows.Forms.Label();
            this.labEmail = new System.Windows.Forms.Label();
            this.labAddress = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtConNum = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.labEmpTyp = new System.Windows.Forms.Label();
            this.labDes = new System.Windows.Forms.Label();
            this.labDepName = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkExit
            // 
            this.linkExit.AutoSize = true;
            this.linkExit.Location = new System.Drawing.Point(767, 707);
            this.linkExit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(31, 15);
            this.linkExit.TabIndex = 7;
            this.linkExit.TabStop = true;
            this.linkExit.Text = "Exit";
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExit_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Skills international";
            // 
            // linkLogOut
            // 
            this.linkLogOut.AutoSize = true;
            this.linkLogOut.Location = new System.Drawing.Point(26, 29);
            this.linkLogOut.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLogOut.Name = "linkLogOut";
            this.linkLogOut.Size = new System.Drawing.Size(51, 15);
            this.linkLogOut.TabIndex = 4;
            this.linkLogOut.TabStop = true;
            this.linkLogOut.Text = "Logout";
            this.linkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogOut_LinkClicked);
            // 
            // labEmpNO
            // 
            this.labEmpNO.AutoSize = true;
            this.labEmpNO.Location = new System.Drawing.Point(27, 31);
            this.labEmpNO.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labEmpNO.Name = "labEmpNO";
            this.labEmpNO.Size = new System.Drawing.Size(55, 15);
            this.labEmpNO.TabIndex = 0;
            this.labEmpNO.Text = "Reg No";
            // 
            // regNo
            // 
            this.regNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNo.FormattingEnabled = true;
            this.regNo.Location = new System.Drawing.Point(92, 26);
            this.regNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.regNo.Name = "regNo";
            this.regNo.Size = new System.Drawing.Size(269, 24);
            this.regNo.TabIndex = 1;
            this.regNo.SelectedIndexChanged += new System.EventHandler(this.regNo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Controls.Add(this.dtpDob);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.txtFName);
            this.groupBox2.Controls.Add(this.labGender);
            this.groupBox2.Controls.Add(this.labDateOfBirth);
            this.groupBox2.Controls.Add(this.labLastName);
            this.groupBox2.Controls.Add(this.labFirstName);
            this.groupBox2.Location = new System.Drawing.Point(30, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(727, 178);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Details";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(229, 140);
            this.rbFemale.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(73, 19);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(134, 140);
            this.rbMale.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 19);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtpDob
            // 
            this.dtpDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDob.Location = new System.Drawing.Point(134, 100);
            this.dtpDob.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(294, 23);
            this.dtpDob.TabIndex = 6;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(133, 66);
            this.txtLName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(572, 23);
            this.txtLName.TabIndex = 5;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(133, 31);
            this.txtFName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(572, 23);
            this.txtFName.TabIndex = 4;
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Location = new System.Drawing.Point(51, 140);
            this.labGender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(54, 15);
            this.labGender.TabIndex = 3;
            this.labGender.Text = "Gender";
            // 
            // labDateOfBirth
            // 
            this.labDateOfBirth.AutoSize = true;
            this.labDateOfBirth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labDateOfBirth.Location = new System.Drawing.Point(8, 106);
            this.labDateOfBirth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labDateOfBirth.Name = "labDateOfBirth";
            this.labDateOfBirth.Size = new System.Drawing.Size(89, 15);
            this.labDateOfBirth.TabIndex = 2;
            this.labDateOfBirth.Text = "Date Of Birth";
            // 
            // labLastName
            // 
            this.labLastName.AutoSize = true;
            this.labLastName.Location = new System.Drawing.Point(25, 70);
            this.labLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labLastName.Name = "labLastName";
            this.labLastName.Size = new System.Drawing.Size(76, 15);
            this.labLastName.TabIndex = 1;
            this.labLastName.Text = "Last Name";
            // 
            // labFirstName
            // 
            this.labFirstName.AutoSize = true;
            this.labFirstName.Location = new System.Drawing.Point(23, 31);
            this.labFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labFirstName.Name = "labFirstName";
            this.labFirstName.Size = new System.Drawing.Size(77, 15);
            this.labFirstName.TabIndex = 0;
            this.labFirstName.Text = "First Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtHphone);
            this.groupBox3.Controls.Add(this.txtMobile);
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.labHomePhone);
            this.groupBox3.Controls.Add(this.LabMobilePhone);
            this.groupBox3.Controls.Add(this.labEmail);
            this.groupBox3.Controls.Add(this.labAddress);
            this.groupBox3.Location = new System.Drawing.Point(30, 249);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox3.Size = new System.Drawing.Size(727, 180);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // txtHphone
            // 
            this.txtHphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHphone.Location = new System.Drawing.Point(482, 139);
            this.txtHphone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHphone.Name = "txtHphone";
            this.txtHphone.Size = new System.Drawing.Size(223, 23);
            this.txtHphone.TabIndex = 7;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(133, 139);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(223, 23);
            this.txtMobile.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(134, 105);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(571, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(134, 29);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(571, 68);
            this.txtAddress.TabIndex = 4;
            // 
            // labHomePhone
            // 
            this.labHomePhone.AutoSize = true;
            this.labHomePhone.Location = new System.Drawing.Point(366, 143);
            this.labHomePhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labHomePhone.Name = "labHomePhone";
            this.labHomePhone.Size = new System.Drawing.Size(90, 15);
            this.labHomePhone.TabIndex = 3;
            this.labHomePhone.Text = "Home Phone";
            // 
            // LabMobilePhone
            // 
            this.LabMobilePhone.AutoSize = true;
            this.LabMobilePhone.Location = new System.Drawing.Point(14, 143);
            this.LabMobilePhone.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabMobilePhone.Name = "LabMobilePhone";
            this.LabMobilePhone.Size = new System.Drawing.Size(96, 15);
            this.LabMobilePhone.TabIndex = 2;
            this.LabMobilePhone.Text = "Mobile Phone";
            // 
            // labEmail
            // 
            this.labEmail.AutoSize = true;
            this.labEmail.Location = new System.Drawing.Point(64, 109);
            this.labEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labEmail.Name = "labEmail";
            this.labEmail.Size = new System.Drawing.Size(44, 15);
            this.labEmail.TabIndex = 1;
            this.labEmail.Text = "Email";
            // 
            // labAddress
            // 
            this.labAddress.AutoSize = true;
            this.labAddress.Location = new System.Drawing.Point(45, 33);
            this.labAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labAddress.Name = "labAddress";
            this.labAddress.Size = new System.Drawing.Size(58, 15);
            this.labAddress.TabIndex = 0;
            this.labAddress.Text = "Address";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtConNum);
            this.groupBox4.Controls.Add(this.txtNIC);
            this.groupBox4.Controls.Add(this.txtPName);
            this.groupBox4.Controls.Add(this.labEmpTyp);
            this.groupBox4.Controls.Add(this.labDes);
            this.groupBox4.Controls.Add(this.labDepName);
            this.groupBox4.Location = new System.Drawing.Point(30, 437);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Size = new System.Drawing.Size(727, 129);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parent Name";
            // 
            // txtConNum
            // 
            this.txtConNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConNum.Location = new System.Drawing.Point(179, 91);
            this.txtConNum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtConNum.Name = "txtConNum";
            this.txtConNum.Size = new System.Drawing.Size(325, 23);
            this.txtConNum.TabIndex = 5;
            // 
            // txtNIC
            // 
            this.txtNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.Location = new System.Drawing.Point(179, 55);
            this.txtNIC.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(325, 23);
            this.txtNIC.TabIndex = 4;
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(179, 21);
            this.txtPName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(526, 23);
            this.txtPName.TabIndex = 3;
            // 
            // labEmpTyp
            // 
            this.labEmpTyp.AutoSize = true;
            this.labEmpTyp.Location = new System.Drawing.Point(46, 95);
            this.labEmpTyp.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labEmpTyp.Name = "labEmpTyp";
            this.labEmpTyp.Size = new System.Drawing.Size(110, 15);
            this.labEmpTyp.TabIndex = 2;
            this.labEmpTyp.Text = "Contact Number";
            // 
            // labDes
            // 
            this.labDes.AutoSize = true;
            this.labDes.Location = new System.Drawing.Point(126, 59);
            this.labDes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labDes.Name = "labDes";
            this.labDes.Size = new System.Drawing.Size(30, 15);
            this.labDes.TabIndex = 1;
            this.labDes.Text = "NIC";
            // 
            // labDepName
            // 
            this.labDepName.AutoSize = true;
            this.labDepName.Location = new System.Drawing.Point(65, 25);
            this.labDepName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labDepName.Name = "labDepName";
            this.labDepName.Size = new System.Drawing.Size(91, 15);
            this.labDepName.TabIndex = 0;
            this.labDepName.Text = "Parent Name";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(30, 574);
            this.btnReg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(125, 32);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(165, 574);
            this.btnUp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(125, 32);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(497, 574);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(632, 574);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 32);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.btnReg);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.regNo);
            this.groupBox1.Controls.Add(this.labEmpNO);
            this.groupBox1.Location = new System.Drawing.Point(16, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(787, 622);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 733);
            this.Controls.Add(this.linkExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLogOut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.registration_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLogOut;
        private System.Windows.Forms.Label labEmpNO;
        private System.Windows.Forms.ComboBox regNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Label labDateOfBirth;
        private System.Windows.Forms.Label labLastName;
        private System.Windows.Forms.Label labFirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHphone;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labHomePhone;
        private System.Windows.Forms.Label LabMobilePhone;
        private System.Windows.Forms.Label labEmail;
        private System.Windows.Forms.Label labAddress;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtConNum;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label labEmpTyp;
        private System.Windows.Forms.Label labDes;
        private System.Windows.Forms.Label labDepName;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}