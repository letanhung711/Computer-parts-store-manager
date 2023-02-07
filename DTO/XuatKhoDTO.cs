using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhoLinhKien.DTO
{
    class XuatKhoDTO
    {
        private string _mapxuat, _manv, _makh, _ngayxuat;
        private int _tongsl, _tongtien;

        public XuatKhoDTO()
        {
            this.Mapxuat = "";
            this.Manv = "";
            this.Makh = "";
            this.Ngayxuat = "";
            this.Tongsl = 0;
            this.Tongtien = 0;
        }
        public XuatKhoDTO(string _mapxuat, string _manv, string _makh, string _ngayxuat, int _tongsl, int _tongtien)
        {
            this.Mapxuat = _mapxuat;
            this.Manv = _manv;
            this.Makh = _makh;
            this.Ngayxuat = _ngayxuat;
            this.Tongsl = _tongsl;
            this.Tongtien = _tongtien;
        }

        public string Makh
        {
            get
            {
                return _makh;
            }

            set
            {
                _makh = value;
            }
        }

        public string Manv
        {
            get
            {
                return _manv;
            }

            set
            {
                _manv = value;
            }
        }

        public string Mapxuat
        {
            get
            {
                return _mapxuat;
            }

            set
            {
                _mapxuat = value;
            }
        }

        public string Ngayxuat
        {
            get
            {
                return _ngayxuat;
            }

            set
            {
                _ngayxuat = value;
            }
        }

        public int Tongsl
        {
            get
            {
                return _tongsl;
            }

            set
            {
                _tongsl = value;
            }
        }

        public int Tongtien
        {
            get
            {
                return _tongtien;
            }

            set
            {
                _tongtien = value;
            }
        }
    }
}
