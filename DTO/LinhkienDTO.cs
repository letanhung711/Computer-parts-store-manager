using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhoLinhKien.DTO
{
    class LinhkienDTO
    {
        private string _malk;
        private string _tenlk;
        private int _gia;
        private string _thuonghieu;
        private int _baohanh;
        private string _mota;
        private string _nhomlk;
        private string _loailk;

        public string Malk
        {
            get
            {
                return _malk;
            }

            set
            {
                _malk = value;
            }
        }

        public string Tenlk
        {
            get
            {
                return _tenlk;
            }

            set
            {
                _tenlk = value;
            }
        }

        public int Gia
        {
            get
            {
                return _gia;
            }

            set
            {
                _gia = value;
            }
        }

        public string Thuonghieu
        {
            get
            {
                return _thuonghieu;
            }

            set
            {
                _thuonghieu = value;
            }
        }

        public int Baohanh
        {
            get
            {
                return _baohanh;
            }

            set
            {
                _baohanh = value;
            }
        }

        public string Mota
        {
            get
            {
                return _mota;
            }

            set
            {
                _mota = value;
            }
        }

        public string Nhomlk
        {
            get
            {
                return _nhomlk;
            }

            set
            {
                _nhomlk = value;
            }
        }

        public string Loailk
        {
            get
            {
                return _loailk;
            }

            set
            {
                _loailk = value;
            }
        }

        public LinhkienDTO()
        {
            this.Malk = "";
            this.Tenlk = "";
            this.Gia = 0;
            this.Thuonghieu = "";
            this.Baohanh = 0;
            this.Mota = "";
            this.Nhomlk = "";
            this.Loailk = "";
        }

        public LinhkienDTO(string _malk, string _tenlk, int _gia, string _thuonghieu, int _baohanh, string _mota, string _nhomlk, string _loailk)
        {
            this.Malk = _malk;
            this.Tenlk = _tenlk;
            this.Gia = _gia;
            this.Thuonghieu = _thuonghieu;
            this.Baohanh = _baohanh;
            this.Mota = _mota;
            this.Nhomlk = _nhomlk;
            this.Loailk = _loailk;
        }
    }
}
