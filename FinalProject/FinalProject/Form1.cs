using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Ghi chú lỗi 
        /// error 401: không tìm thấy node để chèn
        /// error 402: node này là nữ nên không được thêm con vào gia phả
        /// error 403: node đã có vợ/chồng
        /// </summary>
        
        public string NewMember
        {
            set
            {
                cbDelete.Items.Add(value);
            }
        }
        Node Tree = null;
        List<Graphics> LineList = new List<Graphics>();
        List<Panel> PanelList = new List<Panel>();
        int x;
        int y;
        bool isMove;
        Panel movePb;
        public Form1()
        {
            InitializeComponent();
            pnShowTree.Paint += pnShowTree_Paint;
        }

        Label CreateLabel(Node Root)
        {
            Label lb = new Label();
            lb.Name = Root.Name;
            lb.Font = new Font(lb.Font.Name, 12);
            lb.BorderStyle = BorderStyle.FixedSingle;
            lb.Text = Root.Name;
            if (Root.Father == null)
            {
                lb.BackColor = Color.Red;
                lb.ForeColor = Color.White;
            }
            else
            {
                lb.BackColor = Color.White;
            }
            lb.Size = new Size(155, 20);
            lb.MouseDown += Something_MouseDown;
            lb.MouseMove += Pn_MouseMove;
            lb.MouseUp += Pn_MouseUp;
            lb.DoubleClick += Something_DoubleClick;
            return lb;
        }
        PictureBox CreatePicture(Node Root)
        {
            PictureBox pb = new PictureBox();
            pb.Name = Root.Name;
            if (Root.PictureLink != null)
            {
                pb.Image = Image.FromFile(Root.PictureLink);
            }
            else
            {
                if (Root.Gender == 1)
                {
                    pb.Image = FinalProject.Properties.Resources.DefaultImage;
                }
                else
                {
                    pb.Image = FinalProject.Properties.Resources.DefaultAvatar;
                }
            }
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Size = new Size(155, 155);
            pb.MouseDown += Something_MouseDown;
            pb.MouseMove += Pn_MouseMove;
            pb.MouseUp += Pn_MouseUp;
            pb.DoubleClick += Something_DoubleClick;
            return pb;
        }
        Panel CreatePanel(Node Root)
        {
            Panel pn = new Panel();
            pn.Name = Root.Name;
            pn.BackColor = Color.Blue;
            pn.Size = new Size(155, 175);
            PictureBox pb = CreatePicture(Root);
            Label lb = CreateLabel(Root);
            lb.Location = new Point(pb.Location.X, pb.Location.Y + pb.Size.Height);
            pn.Controls.Add(lb);
            pn.Controls.Add(pb);
            pn.Location = new Point(Root.x, Root.y);
            pn.MouseDown += Pn_MouseDown;
            pn.MouseMove += Pn_MouseMove;
            pn.MouseUp += Pn_MouseUp;
            pn.DoubleClick += Something_DoubleClick;
            if (Root.Couple != null)
            {
                PictureBox pbc = CreatePicture(Root.Couple);
                Label lbc = CreateLabel(Root.Couple);
                pbc.Location = new Point(pb.Location.X + 155, pb.Location.Y);
                lbc.Location = new Point(lb.Location.X + 155, lb.Location.Y);
                pn.Controls.Add(pbc);
                pn.Controls.Add(lbc);
                pn.Size = new Size(310, 175);
            }
            return pn;
        }
        Graphics CreateLine(Node Root)
        {
            Graphics g = pnShowTree.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            Point p1 = new Point(Root.x, Root.y);
            if (Root.Father != null)
            {
                Point p2 = new Point(Root.Father.x, Root.Father.y);
                g.DrawLine(blackPen, p1, p2);
            }
            return g;
        }
        void DrawTree(Node Root)
        {
            if (Root != null)
            {
                Panel pn = CreatePanel(Root);
                PanelList.Add(pn);
                pnShowTree.Controls.Add(pn);
                DrawTree(Root.Left);
                DrawTree(Root.Right);
            }
        }
        void DrawTreeLine(Node Root)
        {
            if (Root != null)
            {
                Graphics line = CreateLine(Root);
                LineList.Add(line);
                DrawTreeLine(Root.Left);
                DrawTreeLine(Root.Right);
            }
        }
        public void ClearOldTree()
        {
            while (PanelList.Count != 0)
            {
                pnShowTree.Controls.Remove(PanelList[0]);
                PanelList.Remove(PanelList[0]);
            }
            while (LineList.Count != 0)
            {
                LineList[0].Clear(Color.SkyBlue);
                LineList.Remove(LineList[0]);
            }
        }
        Graphics ReCreateLine(Node p)
        {
            Point p1 = new Point();
            Point p2 = new Point();
            int i = 0, j = 0;
            while (i < PanelList.Count)
            {
                if (string.Compare(PanelList[i].Name, p.Name) == 0)
                {
                    p1 = new Point(PanelList[i].Location.X + 77, PanelList[i].Location.Y + 87);
                    break;
                }
                i++;
            }
            if (p.Father != null)
            {
                while (j < PanelList.Count)
                {
                    if (string.Compare(PanelList[j].Name, p.Father.Name) == 0)
                    {
                        p2 = new Point(PanelList[j].Location.X + 77, PanelList[j].Location.Y + 87);
                        break;
                    }
                    j++;
                }
            }
            else
            {
                p2 = p1;
            }
            Graphics g = pnShowTree.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            g.DrawLine(blackPen, p1, p2);
            return g;
        }
        void ReDrawLine(Node Root)
        {
            if (Root != null)
            {
                Graphics line = ReCreateLine(Root);
                LineList.Add(line);
                ReDrawLine(Root.Left);
                ReDrawLine(Root.Right);
            }
        }
        void ReDraw(Node Root)
        {
            ClearOldTree();
            DrawTree(Tree);
            DrawTreeLine(Tree);
        }
        void SetNodePosition(Node Root)
        {
            if (Root != null)
            {
                foreach(Panel pn in PanelList)
                {
                    if (string.Compare(pn.Name,Root.Name)==0)
                    {
                        Root.x = pn.Location.X;
                        Root.y = pn.Location.Y;
                    }
                }                
                if (Root.Couple != null)
                {
                    foreach (Panel pn in PanelList)
                    {
                        if (pn.Name == Root.Couple.Name)
                        {
                            Root.Couple.x = pn.Location.X;
                            Root.Couple.y = pn.Location.Y;
                        }
                    }
                }
                SetNodePosition(Root.Left);
                SetNodePosition(Root.Right);
            }
        }       //sửa lại vị trí của node sau khi bị dịch chuyển
        Node FindNode(Node Root, string x)
        {
            if (Root != null)
            {
                if (string.Compare(Root.Name, x)==0)
                {
                    return Root;
                }
                else
                {
                    if (Root.Couple != null && Root.Couple.Name == x)
                    {
                        return Root.Couple;
                    }
                    Node p = FindNode(Root.Left, x);
                    if (p == null)
                    {
                        p = FindNode(Root.Right, x);
                    }
                    return p;
                }
            }
            return null;
        }   //tìm 1 node có tên x trong cây
        void LoadTree(ref Node Root)
        {
            StreamReader rd = new StreamReader("DanhSachThanhVien.txt");
            try
            {
                while (!rd.EndOfStream)
                {
                    Node p = new Node();
                    p.Name = rd.ReadLine();
                    p.Gender = int.Parse(rd.ReadLine());
                    p.BirthYear = int.Parse(rd.ReadLine());
                    string FatherName = rd.ReadLine();
                    string Couplename = rd.ReadLine();
                    if (string.Compare(FatherName, "root") == 0)
                    {
                        Root = p;
                        Root.Exist = 1;
                        Root.x = 50;
                        Root.Father = null;
                    }
                    else
                    {
                        int result1 = AddNode(Root, p, FatherName);                       
                        if (result1 != 1)
                        {
                            MessageBox.Show(result1.ToString());
                            break;
                        }
                        int result2 = AddCouple(Root, p, Couplename);
                        if (result2 != 1)
                        {
                            MessageBox.Show(result2.ToString());
                            break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                rd.Close();
            }
        }
        int AddCouple(Node Root, Node NewNode, string x)
        {
            if (string.Compare(x, "none") != 0)
            {
                Node p = FindANode(Root, x);
                if (p != null)
                {
                    if (p.Couple != null)
                    {
                        return 403;
                    }
                    else
                    {
                        NewNode.Father = p.Father;
                        p.Couple = NewNode;
                        NewNode.Couple = p;
                        NewNode.Grade = p.Grade;
                        return 1;
                    }
                }
                else
                {
                    return 401;
                }
            }
            else
            {
                return 1;
            }
        }
        Node FindANode(Node Root, string x)
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
                    Node p = FindANode(Root.Left, x);
                    if (p == null)
                        p = FindANode(Root.Right, x);
                    return p;
                }
            }
            return null;
        }
        int AddNode(Node Root, Node NewNode, string FatherName)
        {
            if (string.Compare(FatherName, "none") != 0)
            {
                Node p = FindANode(Root, FatherName);// p la not cha can chen
                if (p != null)
                {
                    if (p.Gender == 1)
                    {
                        NewNode.Father = p;
                        NewNode.Grade = p.Grade + 1;
                        if (p.Left == null)     //neu chua co con => gan vo 
                        {
                            p.Left = NewNode;
                            NewNode.x = p.x;
                            NewNode.y = p.y + 185;
                        }
                        else                    //neu da co con                                
                        {
                            p = p.Left;         //di xuong con roi di het sang phai tim thang con cuoi cung
                            while (p.Right != null)
                            {
                                p = p.Right;
                            }
                            p.Right = NewNode;
                            NewNode.x = p.x + 315;
                            NewNode.y = p.y;
                        }
                        return 1;
                    }
                    else
                    {
                        return 401;
                    }
                }
                else
                {
                    return 402;
                }
            }
            else
            {
                return 1;
            }
        }
        void RemoveNode(ref Node Root, string name)
        {
            if (Root != null)
            {
                if (string.Compare(Root.Name, name) == 0)
                {
                    if (Root.Father != null)
                    {
                        Root = null;
                    }
                    else
                    {
                        Root = null;
                    }
                    return;
                }
                else
                {
                    if (Root.Couple != null && string.Compare(Root.Couple.Name, name) == 0)
                    {
                        Root.Couple = null;
                    }
                }
                RemoveNode(ref Root.Left, name);
                RemoveNode(ref Root.Right, name);
            }
        }           //xóa node
        void WriteTree(Node Root, StreamWriter wt)
        {
            if (Root != null)
            {
                wt.Write(Root.Name + Environment.NewLine);
                wt.Write(Root.Gender + Environment.NewLine);
                wt.Write(Root.BirthYear + Environment.NewLine);
                if (Root.Father == null)
                {
                    wt.Write("root" + Environment.NewLine);
                }
                else
                {
                    wt.Write(Root.Father.Name + Environment.NewLine);
                }
                wt.Write("none" + Environment.NewLine);
                if (Root.Couple != null)
                {
                    wt.Write(Root.Couple.Name + Environment.NewLine);
                    wt.Write(Root.Couple.Gender + Environment.NewLine);
                    wt.Write(Root.Couple.BirthYear + Environment.NewLine);
                    wt.Write("none" + Environment.NewLine);
                    wt.Write(Root.Name + Environment.NewLine);
                }
                WriteTree(Root.Left, wt);
                WriteTree(Root.Right, wt);
            }
        }
        void SaveTree(Node Root)
        {
            File.WriteAllText("DanhSachThanhVien.txt", String.Empty);
            StreamWriter wt = new StreamWriter("DanhSachThanhVien.txt", true);
            try
            {
                WriteTree(Tree, wt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                wt.Close();
            }
        }
        void AddNodeList(Node Root)
        {
            if (Root != null)
            {
                cbDelete.Items.Add(Root.Name);
                if (Root.Couple != null)
                {
                    cbDelete.Items.Add(Root.Couple.Name);
                }
                AddNodeList(Root.Left);
                AddNodeList(Root.Right);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(Tree==null)
            {
                Tree = new Node();
            }
            SetNodePosition(Tree);
            Form2 f2 = new Form2();
            f2.FakeTree = Tree;
            f2.ShowDialog();
            if (f2.FakeTree.Exist == 1)
            {
                Tree = f2.FakeTree;
                ReDraw(Tree);
            }
            else
            {
                Tree = null;
            }
        }
        private void pnShowTree_Paint(object sender, PaintEventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
            while (LineList.Count != 0)
            {
                LineList[0].Clear(Color.SkyBlue);
                LineList.Remove(LineList[0]);
            }
            ReDrawLine(Tree);
            cbDelete.Items.Clear();
            AddNodeList(Tree);
        }
        private void Pn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMove = true;
                x = e.X;
                y = e.Y;
                foreach (Panel pn in PanelList)
                {
                    if (pn == sender)
                    { 
                        movePb = pn;
                        break;
                    }
                }
            }
        }
        private void Pn_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMove == true)
            {
                movePb.Left += e.X - x;
                movePb.Top += e.Y - y;
            }
        }
        private void Pn_MouseUp(object sender, MouseEventArgs e)
        {
            isMove = false;
        }
        private void Something_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                foreach (Panel pn in PanelList)
                {
                    if (pn.Contains(sender as Control))
                    {
                        isMove = true;
                        x = e.X;
                        y = e.Y;
                        movePb = pn;
                        break;
                    }
                }
            }
        }

        private void Something_DoubleClick(object sender, EventArgs e)
        {
            Node p = null;
            p = FindNode(Tree, (sender as Control).Name);
            Form3 f3 = new Form3();
            f3.Root = p;
            f3.ShowDialog();
            if (f3.IsEditted == true)
            {
                p = f3.Root;
                ReDraw(Tree);
            }
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            string x = txtFindName.Text;
            Node p = FindNode(Tree, x);
            if (p == null)
            {
                MessageBox.Show("Không tìm thấy người này!", "Kết quả tìm kiếm", MessageBoxButtons.OK);
            }
            else
            {
                Form3 f3 = new Form3();
                f3.Root = p;
                f3.ShowDialog();
                if (f3.IsEditted == true)
                {
                    p = f3.Root;
                    ReDraw(Tree);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTree(ref Tree);
            AddNodeList(Tree);
            ReDraw(Tree);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa người này khỏi danh sách không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string DeletedName = cbDelete.Text;
                RemoveNode(ref Tree, DeletedName);
                ReDraw(Tree);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTree(Tree);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
