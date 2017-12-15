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
    public partial class Form2 : Form
    {
        string link;
        private Node fakeTree;
        public Node FakeTree
        {
            get
            {
                return fakeTree;
            }
            set
            {
                fakeTree = value;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }
        void AddRelationShip(Node Root)
        {
            if (Root != null)
            {
                cbRelationship.Items.Add(Root.Name);
                if (Root.Couple != null)
                {
                    cbRelationship.Items.Add(Root.Couple.Name);
                }
                AddRelationShip(Root.Left);
                AddRelationShip(Root.Right);
            }
        }
        Node CreateNode(Node Father)
        {
            Node p = new Node();
            p.Father = Father;
            p.Couple = null;
            p.Grade = 0;
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
            p.Left = null;
            p.Right = null;
            return p;
        }
        int ChangeTree(string x)
        {
            Node p = FindNode(fakeTree, x);// p la not cha can chen
            if (p != null)
            {
                if (p.Gender == 1)
                {
                    Node q = CreateNode(p);
                    q.Grade = p.Grade + 1;
                    if (p.Left == null)     //neu chua co con => gan vo 
                    {
                        p.Left = q;
                        q.x = p.x;
                        q.y = p.y + 185;
                    }
                    else                    //neu da co con                                
                    {
                        p = p.Left;         //di xuong con roi di het sang phai tim thang con cuoi cung
                        while (p.Right != null)
                        {
                            p = p.Right;
                        }
                        p.Right = q;
                        q.x = p.x + 315;
                        q.y = p.y;
                    }
                    return 1;
                }
                else
                {
                    MessageBox.Show("Không thể tiếp tục thêm mối quan hệ cho người này!", "Thông báo", MessageBoxButtons.OK);
                    return -1;
                }
            }
            else
            {               
                MessageBox.Show("Không tìm thấy " + x, "Thông báo", MessageBoxButtons.OK);
                return -1;
            }
        }
        Node FindNode(Node Root, string x)
        {
            if (Root != null)
            {
                if (string.Compare(Root.Name, x) == 0)
                {
                    return Root;
                }
                if (Root.Couple != null && string.Compare(Root.Couple.Name, x) == 0)
                {
                    return Root;
                }
                else
                {
                    Node p = FindNode(Root.Left, x);
                    if (p == null)
                        p = FindNode(Root.Right, x);
                    return p;
                }
            }
            return null;
        }
        int AddCouple(string x)
        {
            Node p = FindNode(fakeTree, x);
            if (p != null)
            {
                if (p.Couple != null)
                {
                    MessageBox.Show("Người này đã có vợ/chồng", "Thông báo", MessageBoxButtons.OK);
                    return -1;
                }
                else
                {
                    Node q = CreateNode(p.Father);
                    p.Couple = q;
                    q.Couple = p;
                    q.Grade = p.Grade;
                    return 1;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy " + x, "Thông báo", MessageBoxButtons.OK);
                return -1;
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
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
            else
            {
                if (fakeTree.Exist == 1)
                {                   
                    if (chbCouple.Checked == false && chbChild.Checked == false)
                    {
                        MessageBox.Show("Hãy chọn một mối quan hệ cho người này!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                    string RelationName = cbRelationship.Text;
                    if (cbRelationship.Text != "")
                    {
                        if (chbChild.Checked == true)
                        {
                            if (ChangeTree(RelationName) == -1)
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (AddCouple(RelationName) == -1)
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập người có mối quan hệ với người này!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                else
                {
                    fakeTree = CreateNode(null);
                    fakeTree.x = 50;
                    fakeTree.Exist = 1;
                }
                this.Close();
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

        private void chbCouple_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCouple.Checked == true && chbChild.Checked == true)
            {
                this.chbChild.Checked = false;
            }
        }

        private void chbChild_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCouple.Checked == true && chbChild.Checked == true)
            {
                this.chbCouple.Checked = false;
            }
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

        private void Form2_Load(object sender, EventArgs e)
        {
            if (fakeTree.Exist == 1)
            {
                lbRelationship.Enabled = true;
                lbWho.Enabled = true;
                chbChild.Enabled = true;
                chbCouple.Enabled = true;
                cbRelationship.Enabled = true;
                AddRelationShip(fakeTree);
            }
            int year = DateTime.Now.Year;
            int i = 0;
            while (i < 200)
            {
                cbYear.Items.Add(year);
                year--;
                i++;
            }
        }

    }
}
