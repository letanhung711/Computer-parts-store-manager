using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhoLinhKien.DTO
{
    class NhapKhoDTO
    {
        private string _mapnhap, _manv, _ngaynhap;
        private int _tongsl, _tongtien;

        public NhapKhoDTO()
        {
            this.Mapnhap = "";
            this.Manv = "";
            this.Ngaynhap = "";
            this.Tongsl = 0;
            this.Tongtien = 0;
        }
        public NhapKhoDTO(string _mapnhap, string _manv, string _ngaynhap, int _tongsl, int _tongtien)
        {
            this.Mapnhap = _mapnhap;
            this.Manv = _manv;
            this.Ngaynhap = _ngaynhap;
            this.Tongsl = _tongsl;
            this.Tongtien = _tongtien;
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

        public string Mapnhap
        {
            get
            {
                return _mapnhap;
            }

            set
            {
                _mapnhap = value;
            }
        }

        public string Ngaynhap
        {
            get
            {
                return _ngaynhap;
            }

            set
            {
                _ngaynhap = value;
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
