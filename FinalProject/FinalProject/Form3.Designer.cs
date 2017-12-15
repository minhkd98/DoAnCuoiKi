namespace FinalProject
{
    partial class Form3
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
            this.btCancel = new System.Windows.Forms.Button();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.chbFemale = new System.Windows.Forms.CheckBox();
            this.chbMale = new System.Windows.Forms.CheckBox();
            this.lbShowName = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lbShowGrade = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.lbShowJob = new System.Windows.Forms.Label();
            this.lbJob = new System.Windows.Forms.Label();
            this.lbShowBirthYear = new System.Windows.Forms.Label();
            this.lbShowGender = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btPicture = new System.Windows.Forms.Button();
            this.lbBirthYear = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.lbNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.ForestGreen;
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Location = new System.Drawing.Point(722, 477);
            this.btCancel.Name = "btCancel";
            this.btCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCancel.Size = new System.Drawing.Size(113, 43);
            this.btCancel.TabIndex = 11;
            this.btCancel.Text = "Quay lại";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Visible = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(414, 164);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 24);
            this.cbYear.TabIndex = 6;
            this.cbYear.Visible = false;
            // 
            // chbFemale
            // 
            this.chbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFemale.Location = new System.Drawing.Point(645, 86);
            this.chbFemale.Name = "chbFemale";
            this.chbFemale.Size = new System.Drawing.Size(104, 46);
            this.chbFemale.TabIndex = 5;
            this.chbFemale.Text = "Nữ";
            this.chbFemale.UseVisualStyleBackColor = true;
            this.chbFemale.Visible = false;
            this.chbFemale.CheckedChanged += new System.EventHandler(this.chbFemale_CheckedChanged);
            // 
            // chbMale
            // 
            this.chbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMale.Location = new System.Drawing.Point(414, 85);
            this.chbMale.Name = "chbMale";
            this.chbMale.Size = new System.Drawing.Size(104, 46);
            this.chbMale.TabIndex = 4;
            this.chbMale.Text = "Nam";
            this.chbMale.UseVisualStyleBackColor = true;
            this.chbMale.Visible = false;
            this.chbMale.CheckedChanged += new System.EventHandler(this.chbMale_CheckedChanged);
            // 
            // lbShowName
            // 
            this.lbShowName.BackColor = System.Drawing.Color.White;
            this.lbShowName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowName.Location = new System.Drawing.Point(414, 12);
            this.lbShowName.Name = "lbShowName";
            this.lbShowName.Size = new System.Drawing.Size(421, 45);
            this.lbShowName.TabIndex = 62;
            this.lbShowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(603, 477);
            this.btSave.Name = "btSave";
            this.btSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btSave.Size = new System.Drawing.Size(113, 43);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Lưu";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Visible = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btEdit
            // 
            this.btEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(603, 477);
            this.btEdit.Name = "btEdit";
            this.btEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btEdit.Size = new System.Drawing.Size(113, 43);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = false;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.ForestGreen;
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.Location = new System.Drawing.Point(722, 477);
            this.btClose.Name = "btClose";
            this.btClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btClose.Size = new System.Drawing.Size(113, 43);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbShowGrade
            // 
            this.lbShowGrade.BackColor = System.Drawing.Color.White;
            this.lbShowGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShowGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowGrade.ForeColor = System.Drawing.Color.Black;
            this.lbShowGrade.Location = new System.Drawing.Point(414, 288);
            this.lbShowGrade.Name = "lbShowGrade";
            this.lbShowGrade.Size = new System.Drawing.Size(144, 45);
            this.lbShowGrade.TabIndex = 58;
            this.lbShowGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGrade
            // 
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.Location = new System.Drawing.Point(267, 280);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(141, 60);
            this.lbGrade.TabIndex = 57;
            this.lbGrade.Text = "Con đời thứ:";
            this.lbGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbShowJob
            // 
            this.lbShowJob.BackColor = System.Drawing.Color.White;
            this.lbShowJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShowJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowJob.Location = new System.Drawing.Point(414, 220);
            this.lbShowJob.Name = "lbShowJob";
            this.lbShowJob.Size = new System.Drawing.Size(421, 45);
            this.lbShowJob.TabIndex = 56;
            this.lbShowJob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbJob
            // 
            this.lbJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJob.Location = new System.Drawing.Point(267, 212);
            this.lbJob.Name = "lbJob";
            this.lbJob.Size = new System.Drawing.Size(141, 60);
            this.lbJob.TabIndex = 55;
            this.lbJob.Text = "Nghề nghiệp:";
            this.lbJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbShowBirthYear
            // 
            this.lbShowBirthYear.BackColor = System.Drawing.Color.White;
            this.lbShowBirthYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShowBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowBirthYear.ForeColor = System.Drawing.Color.Black;
            this.lbShowBirthYear.Location = new System.Drawing.Point(414, 150);
            this.lbShowBirthYear.Name = "lbShowBirthYear";
            this.lbShowBirthYear.Size = new System.Drawing.Size(144, 45);
            this.lbShowBirthYear.TabIndex = 54;
            this.lbShowBirthYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbShowGender
            // 
            this.lbShowGender.BackColor = System.Drawing.Color.White;
            this.lbShowGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbShowGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShowGender.ForeColor = System.Drawing.Color.Black;
            this.lbShowGender.Location = new System.Drawing.Point(414, 85);
            this.lbShowGender.Name = "lbShowGender";
            this.lbShowGender.Size = new System.Drawing.Size(144, 45);
            this.lbShowGender.TabIndex = 53;
            this.lbShowGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btPicture
            // 
            this.btPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPicture.Location = new System.Drawing.Point(18, 250);
            this.btPicture.Name = "btPicture";
            this.btPicture.Size = new System.Drawing.Size(234, 48);
            this.btPicture.TabIndex = 9;
            this.btPicture.Text = "Thay ảnh đại diện";
            this.btPicture.UseVisualStyleBackColor = true;
            this.btPicture.Visible = false;
            this.btPicture.Click += new System.EventHandler(this.btPicture_Click);
            // 
            // lbBirthYear
            // 
            this.lbBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthYear.Location = new System.Drawing.Point(267, 150);
            this.lbBirthYear.Name = "lbBirthYear";
            this.lbBirthYear.Size = new System.Drawing.Size(141, 45);
            this.lbBirthYear.TabIndex = 50;
            this.lbBirthYear.Text = "Năm sinh:";
            this.lbBirthYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGender
            // 
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(267, 85);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(141, 45);
            this.lbGender.TabIndex = 49;
            this.lbGender.Text = "Giới tính:";
            this.lbGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(267, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(141, 45);
            this.lbName.TabIndex = 48;
            this.lbName.Text = "Họ và tên:";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(414, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(421, 36);
            this.txtName.TabIndex = 3;
            this.txtName.Visible = false;
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(414, 223);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(421, 36);
            this.txtJob.TabIndex = 7;
            this.txtJob.Visible = false;
            // 
            // rtxtNote
            // 
            this.rtxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtNote.Location = new System.Drawing.Point(409, 355);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(426, 96);
            this.rtxtNote.TabIndex = 8;
            this.rtxtNote.Text = "";
            // 
            // lbNote
            // 
            this.lbNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Location = new System.Drawing.Point(267, 355);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(141, 47);
            this.lbNote.TabIndex = 71;
            this.lbNote.Text = "Ghi chú:";
            this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form3
            // 
            this.AcceptButton = this.btClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 532);
            this.Controls.Add(this.rtxtNote);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.chbFemale);
            this.Controls.Add(this.chbMale);
            this.Controls.Add(this.lbShowName);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbShowGrade);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.lbShowJob);
            this.Controls.Add(this.lbJob);
            this.Controls.Add(this.lbShowBirthYear);
            this.Controls.Add(this.lbShowGender);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btPicture);
            this.Controls.Add(this.lbBirthYear);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbName);
            this.Name = "Form3";
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.CheckBox chbFemale;
        private System.Windows.Forms.CheckBox chbMale;
        private System.Windows.Forms.Label lbShowName;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lbShowGrade;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Label lbShowJob;
        private System.Windows.Forms.Label lbJob;
        private System.Windows.Forms.Label lbShowBirthYear;
        private System.Windows.Forms.Label lbShowGender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btPicture;
        private System.Windows.Forms.Label lbBirthYear;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.RichTextBox rtxtNote;
        private System.Windows.Forms.Label lbNote;
    }
}