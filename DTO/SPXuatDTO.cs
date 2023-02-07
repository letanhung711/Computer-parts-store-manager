using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhoLinhKien.DTO
{
    class SPXuatDTO
    {
        private string _malk, _mapxuat;
        private int _stt, _slxuat, _giaxuat;

        public SPXuatDTO()
        { 
            this.Malk = "";
            this.Mapxuat = "";
            this.Stt = 0;
            this.Slxuat = 0;
            this.Giaxuat = 0;
        }

        public SPXuatDTO(string _malk, string _mapxuat, int _stt, int _slxuat, int _giaxuat)
        {
            this.Malk = _malk;
            this.Mapxuat = _mapxuat;
            this.Stt = _stt;
            this.Slxuat = _slxuat;
            this.Giaxuat = _giaxuat;
        }

        
        public int Giaxuat
        {
            get
            {
                return _giaxuat;
            }

            set
            {
                _giaxuat = value;
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

        public int Slxuat
        {
            get
            {
                return _slxuat;
            }

            set
            {
                _slxuat = value;
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
