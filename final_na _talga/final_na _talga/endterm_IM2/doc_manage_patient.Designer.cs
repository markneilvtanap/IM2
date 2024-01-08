namespace endterm_IM2
{
    partial class doc_manage_patient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doc_manage_patient));
            this.label1 = new System.Windows.Forms.Label();
            this.stud_search = new System.Windows.Forms.TextBox();
            this.stud_datagridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stud_datagridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "Search";
            // 
            // stud_search
            // 
            this.stud_search.Location = new System.Drawing.Point(41, 190);
            this.stud_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_search.Name = "stud_search";
            this.stud_search.Size = new System.Drawing.Size(653, 22);
            this.stud_search.TabIndex = 109;
            this.stud_search.TextChanged += new System.EventHandler(this.stud_search_TextChanged);
            // 
            // stud_datagridView
            // 
            this.stud_datagridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stud_datagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stud_datagridView.Location = new System.Drawing.Point(30, 224);
            this.stud_datagridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stud_datagridView.Name = "stud_datagridView";
            this.stud_datagridView.RowHeadersWidth = 51;
            this.stud_datagridView.RowTemplate.Height = 24;
            this.stud_datagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stud_datagridView.Size = new System.Drawing.Size(1110, 331);
            this.stud_datagridView.TabIndex = 108;
            this.stud_datagridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stud_datagridView_CellMouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1178, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 148;
            this.pictureBox1.TabStop = false;
            // 
            // doc_manage_patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stud_search);
            this.Controls.Add(this.stud_datagridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "doc_manage_patient";
            this.Size = new System.Drawing.Size(1181, 572);
            this.Load += new System.EventHandler(this.doc_manage_patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stud_datagridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stud_search;
        private System.Windows.Forms.DataGridView stud_datagridView;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
