using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Node
    {
        public string Name { get; set; }
        public int Gender { get; set; }
        public int BirthYear { get; set; }
        public int Grade { get; set; }      //lưu cấp của node
        public string Job { get; set; }
        public string Notice { get; set; }
        public string PictureLink { get; set; }  //lưu đường link hình ảnh
        public Node Father;         //cho biết node cha của node này
        public Node Couple;           //cho biết vợ/ chồng của node này
        public int Exist = 0;       //cho biết đã có node gốc chưa
        public int x = 0;           // tọa độ x
        public int y = 0;           // tọa độ y
        public Node Left;
        public Node Right;
    }
}
