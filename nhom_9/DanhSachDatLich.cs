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
    internal class DanhSachDatLich
    {
        private List<DatLich> _danhSachDatLich;
        
        public DanhSachDatLich()
        {
            _danhSachDatLich = new List<DatLich>();
        }
        public List<DatLich> danhSachDatLich
        {
            get { return this._danhSachDatLich.ToList(); }
            set { this._danhSachDatLich = value; }
        }
        public void AddDanhSachDatLich(DatLich dsdt)
        {
           
            this._danhSachDatLich.Add(dsdt);
        }
      
        public bool timTG(DatLich dl)
        {
            foreach (DatLich d in this._danhSachDatLich)
            {
                if (d.thoigian.Equals(dl.thoigian))
                {
                    return true;
                }
            }
            return false;
        }
        public DatLich TimTheoID(string id)
        {
            return _danhSachDatLich.FirstOrDefault(d => d.id == id);
        }
        public void SuaDanhSachDatLich(string id, DatLich datLichMoi)
        {

            DatLich datLichCanSua = _danhSachDatLich.FirstOrDefault(d => d.id == id);

            if (datLichCanSua != null)
            {

                datLichCanSua.tieude = datLichMoi.tieude;
                datLichCanSua.noidung = datLichMoi.noidung;
                datLichCanSua.thoigian = datLichMoi.thoigian;
                datLichCanSua.trangthai = datLichMoi.trangthai;



            }

        }


        public void XoaDanhSachDatLich(string id)
        {
            
            DatLich datLichCanXoa = _danhSachDatLich.FirstOrDefault(d => d.id == id);

            if (datLichCanXoa != null)
            {
            
                _danhSachDatLich.Remove(datLichCanXoa);
               
            }
        }

        public void UpdateIDs()
        {
            for (int i = 0; i < _danhSachDatLich.Count; i++)
            {
                _danhSachDatLich[i].id = Guid.NewGuid().ToString();
            }
        }
        // Thêm phương thức tìm kiếm vào lớp DanhSachDatLich




        internal static object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }



    }
}


