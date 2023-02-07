using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhoLinhKien.DTO
{
    class NhanVienDTO
    {
        private string _manv;
        private string _tennv;
        private string _gioitinh;
        private string _sdt;
        private string _diachi;
        private string _matkhau;
        private string _chucvu;

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

        public string Tennv
        {
            get
            {
                return _tennv;
            }

            set
            {
                _tennv = value;
            }
        }

        public string Gioitinh
        {
            get
            {
                return _gioitinh;
            }

            set
            {
                _gioitinh = value;
            }
        }

        public string Sdt
        {
            get
            {
                return _sdt;
            }

            set
            {
                _sdt = value;
            }
        }

        public string Diachi
        {
            get
            {
                return _diachi;
            }

            set
            {
                _diachi = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return _matkhau;
            }

            set
            {
                _matkhau = value;
            }
        }

        public string Chucvu
        {
            get
            {
                return _chucvu;
            }

            set
            {
                _chucvu = value;
            }
        }

        public NhanVienDTO()
        {
            this.Manv = "";
            this.Tennv = "";
            this.Gioitinh = "";
            this.Sdt = "";
            this.Diachi = "";
            this.Matkhau = "";
            this.Chucvu = "";
        }
        public NhanVienDTO(string _manv, string _tennv, string _gioitinh, string _sdt, string _diachi, string _matkhau, string _chucvu)
        {
            this.Manv = _manv;
            this.Tennv = _tennv;
            this.Gioitinh = _gioitinh;
            this.Sdt = _sdt;
            this.Diachi = _diachi;
            this.Matkhau = _matkhau;
            this.Chucvu = _chucvu;
        }
    }
}
