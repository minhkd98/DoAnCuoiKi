namespace FinalProject
{
    partial class Form2
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
            this.btPicture = new System.Windows.Forms.Button();
            this.lbWho = new System.Windows.Forms.Label();
            this.cbRelationship = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chbChild = new System.Windows.Forms.CheckBox();
            this.chbCouple = new System.Windows.Forms.CheckBox();
            this.chbFemale = new System.Windows.Forms.CheckBox();
            this.chbMale = new System.Windows.Forms.CheckBox();
            this.lbRelationship = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btPicture
            // 
            this.btPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPicture.Location = new System.Drawing.Point(12, 256);
            this.btPicture.Name = "btPicture";
            this.btPicture.Size = new System.Drawing.Size(234, 46);
            this.btPicture.TabIndex = 10;
            this.btPicture.Text = "Thay ảnh đại diện";
            this.btPicture.UseVisualStyleBackColor = true;
            this.btPicture.Click += new System.EventHandler(this.btPicture_Click);
            // 
            // lbWho
            // 
            this.lbWho.Enabled = false;
            this.lbWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWho.Location = new System.Drawing.Point(550, 276);
            this.lbWho.Name = "lbWho";
            this.lbWho.Size = new System.Drawing.Size(57, 47);
            this.lbWho.TabIndex = 52;
            this.lbWho.Text = "Của";
            this.lbWho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbRelationship
            // 
            this.cbRelationship.Enabled = false;
            this.cbRelationship.FormattingEnabled = true;
            this.cbRelationship.Location = new System.Drawing.Point(613, 291);
            this.cbRelationship.Name = "cbRelationship";
            this.cbRelationship.Size = new System.Drawing.Size(221, 24);
            this.cbRelationship.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(261, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 60);
            this.label4.TabIndex = 50;
            this.label4.Text = "Nghề nghiệp:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chbChild
            // 
            this.chbChild.Enabled = false;
            this.chbChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbChild.Location = new System.Drawing.Point(408, 308);
            this.chbChild.Name = "chbChild";
            this.chbChild.Size = new System.Drawing.Size(104, 46);
            this.chbChild.TabIndex = 7;
            this.chbChild.Text = "Con";
            this.chbChild.UseVisualStyleBackColor = true;
            this.chbChild.CheckedChanged += new System.EventHandler(this.chbChild_CheckedChanged);
            // 
            // chbCouple
            // 
            this.chbCouple.Enabled = false;
            this.chbCouple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCouple.Location = new System.Drawing.Point(408, 256);
            this.chbCouple.Name = "chbCouple";
            this.chbCouple.Size = new System.Drawing.Size(144, 46);
            this.chbCouple.TabIndex = 6;
            this.chbCouple.Text = "Vợ/Chồng";
            this.chbCouple.UseVisualStyleBackColor = true;
            this.chbCouple.CheckedChanged += new System.EventHandler(this.chbCouple_CheckedChanged);
            // 
            // chbFemale
            // 
            this.chbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFemale.Location = new System.Drawing.Point(639, 71);
            this.chbFemale.Name = "chbFemale";
            this.chbFemale.Size = new System.Drawing.Size(104, 46);
            this.chbFemale.TabIndex = 3;
            this.chbFemale.Text = "Nữ";
            this.chbFemale.UseVisualStyleBackColor = true;
            this.chbFemale.CheckedChanged += new System.EventHandler(this.chbFemale_CheckedChanged);
            // 
            // chbMale
            // 
            this.chbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMale.Location = new System.Drawing.Point(408, 70);
            this.chbMale.Name = "chbMale";
            this.chbMale.Size = new System.Drawing.Size(104, 46);
            this.chbMale.TabIndex = 2;
            this.chbMale.Text = "Nam";
            this.chbMale.UseVisualStyleBackColor = true;
            this.chbMale.CheckedChanged += new System.EventHandler(this.chbMale_CheckedChanged);
            // 
            // lbRelationship
            // 
            this.lbRelationship.Enabled = false;
            this.lbRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRelationship.Location = new System.Drawing.Point(261, 276);
            this.lbRelationship.Name = "lbRelationship";
            this.lbRelationship.Size = new System.Drawing.Size(141, 47);
            this.lbRelationship.TabIndex = 45;
            this.lbRelationship.Text = "Mối quan hệ:";
            this.lbRelationship.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.BackColor = System.Drawing.Color.ForestGreen;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(722, 477);
            this.btCancel.Name = "btCancel";
            this.btCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCancel.Size = new System.Drawing.Size(113, 43);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Đóng";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(408, 143);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 24);
            this.cbYear.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(603, 477);
            this.btAdd.Name = "btAdd";
            this.btAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btAdd.Size = new System.Drawing.Size(113, 43);
            this.btAdd.TabIndex = 11;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 47);
            this.label3.TabIndex = 40;
            this.label3.Text = "Năm sinh:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 46);
            this.label2.TabIndex = 39;
            this.label2.Text = "Giới tính:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 45);
            this.label1.TabIndex = 37;
            this.label1.Text = "Họ và tên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(408, 14);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(426, 36);
            this.txtName.TabIndex = 1;
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(408, 195);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(426, 36);
            this.txtJob.TabIndex = 5;
            // 
            // lbNote
            // 
            this.lbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(261, 370);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(141, 47);
            this.lbNote.TabIndex = 57;
            this.lbNote.Text = "Ghi chú:";
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rtxtNote
            // 
            this.rtxtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtNote.Location = new System.Drawing.Point(408, 370);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(426, 96);
            this.rtxtNote.TabIndex = 9;
            this.rtxtNote.Text = "";
            // 
            // Form2
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 532);
            this.Controls.Add(this.rtxtNote);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btPicture);
            this.Controls.Add(this.lbWho);
            this.Controls.Add(this.cbRelationship);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chbChild);
            this.Controls.Add(this.chbCouple);
            this.Controls.Add(this.chbFemale);
            this.Controls.Add(this.chbMale);
            this.Controls.Add(this.lbRelationship);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(865, 579);
            this.MinimumSize = new System.Drawing.Size(865, 579);
            this.Name = "Form2";
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btPicture;
        private System.Windows.Forms.Label lbWho;
        private System.Windows.Forms.ComboBox cbRelationship;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbChild;
        private System.Windows.Forms.CheckBox chbCouple;
        private System.Windows.Forms.CheckBox chbFemale;
        private System.Windows.Forms.CheckBox chbMale;
        private System.Windows.Forms.Label lbRelationship;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.RichTextBox rtxtNote;
    }
}