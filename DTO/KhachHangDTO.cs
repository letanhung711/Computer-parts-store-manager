using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhoLinhKien.DTO
{
    class KhachHangDTO
    {
        private string _makh;
        private string _tenkh;
        private string _sdt;
        private string _diachi;
        private string _ngaytao;
        private string _ngaycapnhat;

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

        public string Tenkh
        {
            get
            {
                return _tenkh;
            }

            set
            {
                _tenkh = value;
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

        public string Ngaytao
        {
            get
            {
                return _ngaytao;
            }

            set
            {
                _ngaytao = value;
            }
        }

        public string Ngaycapnhat
        {
            get
            {
                return _ngaycapnhat;
            }

            set
            {
                _ngaycapnhat = value;
            }
        }

        public KhachHangDTO()
        {
            this.Makh = "";
            this.Tenkh = "";
            this.Sdt = "";
            this.Diachi = "";
            this.Ngaytao = "";
            this.Ngaycapnhat = "";
        }
        public KhachHangDTO(string _makh, string _tenkh, string _sdt, string _diachi, string _ngaytao, string _ngaycapnhat)
        {
            this.Makh = _makh;
            this.Tenkh = _tenkh;
            this.Sdt = _sdt;
            this.Diachi = _diachi;
            this.Ngaytao = _ngaytao;
            this.Ngaycapnhat = _ngaycapnhat;
        }
    }
}
