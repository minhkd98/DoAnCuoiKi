namespace FinalProject
{
    partial class Form1
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
            this.pnTittle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnRight = new System.Windows.Forms.Panel();
            this.btExit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbDelete = new System.Windows.Forms.ComboBox();
            this.btFind = new System.Windows.Forms.Button();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.pnShowTree = new System.Windows.Forms.Panel();
            this.pnTittle.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTittle
            // 
            this.pnTittle.Controls.Add(this.label1);
            this.pnTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTittle.Location = new System.Drawing.Point(0, 0);
            this.pnTittle.Name = "pnTittle";
            this.pnTittle.Size = new System.Drawing.Size(982, 100);
            this.pnTittle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(957, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cây Gia Phả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.btExit);
            this.pnRight.Controls.Add(this.btAdd);
            this.pnRight.Controls.Add(this.cbDelete);
            this.pnRight.Controls.Add(this.btFind);
            this.pnRight.Controls.Add(this.txtFindName);
            this.pnRight.Controls.Add(this.btDelete);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(674, 100);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(308, 516);
            this.pnRight.TabIndex = 8;
            // 
            // btExit
            // 
            this.btExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(186, 453);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(110, 51);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btAdd.Location = new System.Drawing.Point(14, 0);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(269, 44);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm thành viên";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbDelete
            // 
            this.cbDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDelete.FormattingEnabled = true;
            this.cbDelete.Location = new System.Drawing.Point(14, 285);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(269, 37);
            this.cbDelete.TabIndex = 4;
            // 
            // btFind
            // 
            this.btFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.Location = new System.Drawing.Point(14, 95);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(96, 41);
            this.btFind.TabIndex = 1;
            this.btFind.Text = "Tìm";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // txtFindName
            // 
            this.txtFindName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFindName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFindName.Location = new System.Drawing.Point(14, 142);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(269, 36);
            this.txtFindName.TabIndex = 2;
            // 
            // btDelete
            // 
            this.btDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(14, 228);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(110, 51);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // pnShowTree
            // 
            this.pnShowTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnShowTree.AutoScroll = true;
            this.pnShowTree.BackColor = System.Drawing.Color.SkyBlue;
            this.pnShowTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnShowTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnShowTree.Location = new System.Drawing.Point(0, 100);
            this.pnShowTree.Name = "pnShowTree";
            this.pnShowTree.Size = new System.Drawing.Size(668, 504);
            this.pnShowTree.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 616);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnShowTree);
            this.Controls.Add(this.pnTittle);
            this.Name = "Form1";
            this.Text = "Family Tree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnTittle.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.pnRight.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTittle;
        private System.Windows.Forms.Panel pnRight;
        public System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox cbDelete;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel pnShowTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
    }
}

