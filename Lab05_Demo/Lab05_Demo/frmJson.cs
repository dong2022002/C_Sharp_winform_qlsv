using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Demo
{
    public partial class frmJson : Form
    {
        public frmJson()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private List<StudentInfo> LoadJSON(string Path)
        {
            
            List<StudentInfo> List = new List<StudentInfo>();
         
            StreamReader r = new StreamReader(Path);
            string json = r.ReadToEnd(); 
                                        
            var array = (JObject)JsonConvert.DeserializeObject(json);
            // Lấy đối tượng sinhvien
            var students = array["sinhvien"].Children();
            foreach (var item in students)
            {              
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["hoten"].Value<string>();
                int tuoi = item["tuoi"].Value<int>();
                double diem = item["diem"].Value<double>();
                bool tongiao = item["tongiao"].Value<bool>();              
                StudentInfo info = new StudentInfo(mssv, hoten, tuoi, diem,
                tongiao);


                List.Add(info);
            }
            return List;
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            string Str = ""; 
            string Path = "../../JSONExample.json"; 
            List<StudentInfo> List = LoadJSON(Path); 
            for (int i = 0; i < List.Count; i++) 
            {
                StudentInfo info = List[i];
                Str += "Sinh vien" + (i + 1) + "có MSSV: " + info.MSSV + ", họ tên: " + info.Hoten + ",điểm TB: " + info.Diem + "\n";
                //Str += string.Format("Sinh viên {0} có MSSV: {1}, họ tên: {2},điểm TB: { 3}\r\n", (i + 1), info.MSSV, info.Hoten, info.Diem);
            }
            MessageBox.Show(Str);
        }
    }
}
