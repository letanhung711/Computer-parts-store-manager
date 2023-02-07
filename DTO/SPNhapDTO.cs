using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhoLinhKien.DTO
{
    class SPNhapDTO
    {
        private string _malk, _mapnhap;
        private int _stt, _gianhap, _slnhap;

        public SPNhapDTO()
        {
            this.Malk = "";
            this.Mapnhap = "";
            this.Stt = 0;
            this.Gianhap = 0;
            this.Slnhap = 0;
        }
        public SPNhapDTO(string _malk, string _mapnhap, int _stt, int _gianhap, int _slnhap)
        {
            this.Malk = _malk;
            this.Mapnhap = _mapnhap;
            this.Stt = _stt;
            this.Gianhap = _gianhap;
            this.Slnhap = _slnhap;
        }

        public int Gianhap
        {
            get
            {
                return _gianhap;
            }

            set
            {
                _gianhap = value;
            }
        }

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

        public int Slnhap
        {
            get
            {
                return _slnhap;
            }

            set
            {
                _slnhap = value;
            }
        }

        public int Stt
        {
            get
            {
                return _stt;
            }

            set
            {
                _stt = value;
            }
        }
    }
}
