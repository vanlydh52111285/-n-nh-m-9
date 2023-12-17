using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace nhom_9
{
    [Serializable]
    internal class DatLich
    {
        private string _id;
        private string _tieude;
        private string _noidung;       
        private DateTime _thoigian;
        private string _trangthai;
       
        public DatLich()
        {
            this._id ="";
            this._tieude = "không có tiêu đề ";
            this._noidung = "không có nội dung ";
            this._thoigian = DateTime.Now;
            this._trangthai = "chưa hoàn thành ";
        }
        public DatLich(string id, string tieude, string noidung, DateTime thoigian, string trangthai)
        {
            this._id = id;
            this._tieude = tieude;
            this._noidung = noidung;           
            this._thoigian=thoigian;
            this._trangthai = trangthai;
          
        }
        public string id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public string tieude
        {
            get { return this._tieude; }
            set { this._tieude = value; }
        }
        public string noidung
        {
            get { return this._noidung; }
            set { this._noidung = value; }
        }
       
        public DateTime thoigian
        {
            get { return this._thoigian; }
            set { this._thoigian = value; }
        }
        public string trangthai
        {
            get { return this._trangthai; }
            set { this._trangthai = value; }
        }
        public void SuaDanhSachDatLich(string tieude, string noidung, DateTime thoigian, string trangthai)
        {
            this.tieude = tieude;
            this.noidung = noidung;
            this.thoigian = thoigian;
            this.trangthai = trangthai;
        }
    }
}
