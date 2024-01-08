namespace endterm_IM2
{
    partial class admin_patient
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
            this.label2 = new System.Windows.Forms.Label();
            this.stud_emer_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.stud_cancel = new System.Windows.Forms.Button();
            this.stud_delete = new System.Windows.Forms.Button();
            this.stud_edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stud_search = new System.Windows.Forms.TextBox();
            this.stud_datagridView = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.stud_emer_add = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.stud_address = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stud_age = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.stud_Fname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stud_emer_no = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stud_LName = new System.Windows.Forms.TextBox();
            this.stud_id = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stud_course = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.stud_level = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.stud_contact = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stud_datagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 18);
            this.label2.TabIndex = 110;
            this.label2.Text = "Emerergency Contact Person";
            // 
            // stud_emer_name
            // 
            this.stud_emer_name.Location = new System.Drawing.Point(56, 446);
            this.stud_emer_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_emer_name.Name = "stud_emer_name";
            this.stud_emer_name.Size = new System.Drawing.Size(343, 22);
            this.stud_emer_name.TabIndex = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(184, 161);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(195, 57);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sex";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 31);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(104, 31);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 22);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // stud_cancel
            // 
            this.stud_cancel.BackColor = System.Drawing.Color.Gold;
            this.stud_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_cancel.Location = new System.Drawing.Point(937, 607);
            this.stud_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_cancel.Name = "stud_cancel";
            this.stud_cancel.Size = new System.Drawing.Size(119, 44);
            this.stud_cancel.TabIndex = 107;
            this.stud_cancel.Text = "CANCEL";
            this.stud_cancel.UseVisualStyleBackColor = false;
            this.stud_cancel.Click += new System.EventHandler(this.stud_cancel_Click);
            // 
            // stud_delete
            // 
            this.stud_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stud_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_delete.Location = new System.Drawing.Point(790, 607);
            this.stud_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_delete.Name = "stud_delete";
            this.stud_delete.Size = new System.Drawing.Size(119, 44);
            this.stud_delete.TabIndex = 106;
            this.stud_delete.Text = "DELETE";
            this.stud_delete.UseVisualStyleBackColor = false;
            this.stud_delete.Click += new System.EventHandler(this.stud_delete_Click);
            // 
            // stud_edit
            // 
            this.stud_edit.BackColor = System.Drawing.Color.Gold;
            this.stud_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_edit.Location = new System.Drawing.Point(649, 607);
            this.stud_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_edit.Name = "stud_edit";
            this.stud_edit.Size = new System.Drawing.Size(119, 44);
            this.stud_edit.TabIndex = 105;
            this.stud_edit.Text = "EDIT";
            this.stud_edit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(581, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 103;
            this.label1.Text = "Search";
            // 
            // stud_search
            // 
            this.stud_search.Location = new System.Drawing.Point(585, 62);
            this.stud_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_search.Name = "stud_search";
            this.stud_search.Size = new System.Drawing.Size(553, 22);
            this.stud_search.TabIndex = 102;
            this.stud_search.TextChanged += new System.EventHandler(this.stud_search_TextChanged);
            // 
            // stud_datagridView
            // 
            this.stud_datagridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stud_datagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stud_datagridView.Location = new System.Drawing.Point(585, 105);
            this.stud_datagridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_datagridView.Name = "stud_datagridView";
            this.stud_datagridView.RowHeadersWidth = 51;
            this.stud_datagridView.RowTemplate.Height = 24;
            this.stud_datagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stud_datagridView.Size = new System.Drawing.Size(555, 491);
            this.stud_datagridView.TabIndex = 101;
            this.stud_datagridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stud_datagridView_CellMouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 550);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 18);
            this.label13.TabIndex = 96;
            this.label13.Text = "Emergency Contact Address";
            // 
            // stud_emer_add
            // 
            this.stud_emer_add.Location = new System.Drawing.Point(57, 571);
            this.stud_emer_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_emer_add.Multiline = true;
            this.stud_emer_add.Name = "stud_emer_add";
            this.stud_emer_add.Size = new System.Drawing.Size(348, 43);
            this.stud_emer_add.TabIndex = 95;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 346);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 18);
            this.label12.TabIndex = 94;
            this.label12.Text = "Address";
            // 
            // stud_address
            // 
            this.stud_address.Location = new System.Drawing.Point(55, 367);
            this.stud_address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_address.Multiline = true;
            this.stud_address.Name = "stud_address";
            this.stud_address.Size = new System.Drawing.Size(345, 36);
            this.stud_address.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(413, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 18);
            this.label11.TabIndex = 92;
            this.label11.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 18);
            this.label3.TabIndex = 91;
            this.label3.Text = "Age";
            // 
            // stud_age
            // 
            this.stud_age.Location = new System.Drawing.Point(49, 185);
            this.stud_age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_age.Name = "stud_age";
            this.stud_age.Size = new System.Drawing.Size(100, 22);
            this.stud_age.TabIndex = 90;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(417, 185);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 22);
            this.dateTimePicker1.TabIndex = 89;
            // 
            // stud_Fname
            // 
            this.stud_Fname.Location = new System.Drawing.Point(49, 124);
            this.stud_Fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_Fname.Name = "stud_Fname";
            this.stud_Fname.Size = new System.Drawing.Size(251, 22);
            this.stud_Fname.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 18);
            this.label8.TabIndex = 86;
            this.label8.Text = "Emergency Contact Number";
            // 
            // stud_emer_no
            // 
            this.stud_emer_no.Location = new System.Drawing.Point(57, 506);
            this.stud_emer_no.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_emer_no.Name = "stud_emer_no";
            this.stud_emer_no.Size = new System.Drawing.Size(272, 22);
            this.stud_emer_no.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 79;
            this.label6.Text = "Lastname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 78;
            this.label5.Text = "Firstname";
            // 
            // stud_LName
            // 
            this.stud_LName.Location = new System.Drawing.Point(319, 124);
            this.stud_LName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_LName.Name = "stud_LName";
            this.stud_LName.Size = new System.Drawing.Size(251, 22);
            this.stud_LName.TabIndex = 77;
            // 
            // stud_id
            // 
            this.stud_id.AutoSize = true;
            this.stud_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_id.Location = new System.Drawing.Point(51, 36);
            this.stud_id.Name = "stud_id";
            this.stud_id.Size = new System.Drawing.Size(118, 18);
            this.stud_id.TabIndex = 112;
            this.stud_id.Text = "Student ID No.";
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(51, 58);
            this.student_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(245, 22);
            this.student_id.TabIndex = 111;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 18);
            this.label4.TabIndex = 114;
            this.label4.Text = "Course/Program";
            // 
            // stud_course
            // 
            this.stud_course.Location = new System.Drawing.Point(49, 251);
            this.stud_course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_course.Name = "stud_course";
            this.stud_course.Size = new System.Drawing.Size(309, 22);
            this.stud_course.TabIndex = 113;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(413, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 18);
            this.label14.TabIndex = 116;
            this.label14.Text = "Year Level";
            // 
            // stud_level
            // 
            this.stud_level.Location = new System.Drawing.Point(416, 251);
            this.stud_level.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_level.Name = "stud_level";
            this.stud_level.Size = new System.Drawing.Size(153, 22);
            this.stud_level.TabIndex = 115;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(51, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 18);
            this.label15.TabIndex = 118;
            this.label15.Text = "Contact No.";
            // 
            // stud_contact
            // 
            this.stud_contact.Location = new System.Drawing.Point(53, 309);
            this.stud_contact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_contact.Name = "stud_contact";
            this.stud_contact.Size = new System.Drawing.Size(309, 22);
            this.stud_contact.TabIndex = 117;
            // 
            // admin_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1359, 734);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.stud_contact);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.stud_level);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stud_course);
            this.Controls.Add(this.stud_id);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stud_emer_name);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stud_cancel);
            this.Controls.Add(this.stud_delete);
            this.Controls.Add(this.stud_edit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stud_search);
            this.Controls.Add(this.stud_datagridView);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.stud_emer_add);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.stud_address);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stud_age);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.stud_Fname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stud_emer_no);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stud_LName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "admin_patient";
            this.Text = "admin_patient";
            this.Load += new System.EventHandler(this.admin_patient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stud_datagridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stud_emer_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button stud_cancel;
        private System.Windows.Forms.Button stud_delete;
        private System.Windows.Forms.Button stud_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stud_search;
        private System.Windows.Forms.DataGridView stud_datagridView;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox stud_emer_add;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox stud_address;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stud_age;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox stud_Fname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox stud_emer_no;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stud_LName;
        private System.Windows.Forms.Label stud_id;
        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stud_course;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox stud_level;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox stud_contact;
    }
}