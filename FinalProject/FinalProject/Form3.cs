using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form3 : Form
    {
        public bool IsEditted = false;
        string link;
        private Node root;
        public Node Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        void ShowInfo(Node Root)
        {
            lbShowName.Text = Root.Name;
            rtxtNote.Text = Root.Notice;
            lbShowBirthYear.Text = Root.BirthYear.ToString();
            if (Root.Gender == 1)
            {
                lbShowGender.Text = "Nam";
            }
            else
            {
                lbShowGender.Text = "Nữ";
            }
            if (Root.BirthYear != -1)
            {
                lbShowBirthYear.Text = Root.BirthYear.ToString();
            }
            if (Root.PictureLink != null)
            {
                pictureBox1.Image = Image.FromFile(Root.PictureLink);
            }
            else
            {
                pictureBox1.Image = FinalProject.Properties.Resources.DefaultImage;
            }
            lbShowJob.Text = Root.Job;
            lbShowGrade.Text = Root.Grade.ToString();
        }
        void EditNode(ref Node p)
        {
            p.Name = txtName.Text;
            p.Job = txtJob.Text;
            p.Notice = rtxtNote.Text;
            p.PictureLink = link;
            if (cbYear.Text != "")
            {
                p.BirthYear = int.Parse(cbYear.Text);
            }
            else
            {
                p.BirthYear = -1;
            }
            if (chbMale.Checked == true)
            {
                p.Gender = 1;
            }
            else
            {
                if (chbFemale.Checked == true)
                {
                    p.Gender = 2;
                }
            }
        }

        void OnOffLabel(bool t, bool f)
        {
            lbShowName.Visible = t;
            lbShowBirthYear.Visible = t;
            lbShowGender.Visible = t;
            lbShowJob.Visible = t;
            lbGrade.Visible = t;
            lbShowGrade.Visible = t;
            rtxtNote.Enabled = f;
            txtName.Visible = f;
            txtJob.Visible = f;
            cbYear.Visible = f;
            chbFemale.Visible = f;
            chbMale.Visible = f;
            btPicture.Visible = f;
            btSave.Visible = f;
            btCancel.Visible = f;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            int i = 0;
            while (i < 200)
            {
                cbYear.Items.Add(year);
                year--;
                i++;
            }
            if(root.Gender==1)
            {
                chbMale.Checked = true;
            }
            else
            {
                chbFemale.Checked = true;
            }
            ShowInfo(root);
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            OnOffLabel(true, false);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Tên không hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (chbMale.Checked == false && chbFemale.Checked == false)
            {
                MessageBox.Show("Hãy chọn giới tính cho người này!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin của người này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EditNode(ref root);
                OnOffLabel(true, false);
                ShowInfo(root);
                IsEditted = true;
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            AcceptButton = btSave;
            OnOffLabel(false, true);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(fd.FileName);
                link = fd.FileName;
            }
        }

        private void chbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMale.Checked == true && chbFemale.Checked == true)
            {
                this.chbFemale.Checked = false;
            }
        }

        private void chbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMale.Checked == true && chbFemale.Checked == true)
            {
                this.chbMale.Checked = false;
            }
        }
    }
}
