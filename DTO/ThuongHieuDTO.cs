using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhoLinhKien.DTO
{
    class ThuongHieuDTO
    {
        private string _math;
        private string _tenth;
        private string _ngaytao;
        private string _ngaycapnhat;
        private string _manhomlk;

        public string Math
        {
            get
            {
                return _math;
            }

            set
            {
                _math = value;
            }
        }

        public string Tenth
        {
            get
            {
                return _tenth;
            }

            set
            {
                _tenth = value;
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

        public string Manhomlk
        {
            get
            {
                return _manhomlk;
            }

            set
            {
                _manhomlk = value;
            }
        }

        public ThuongHieuDTO()
        {
            this.Math = "";
            this.Tenth = "";
            this.Ngaytao = "";
            this.Ngaycapnhat = "";
            this.Manhomlk = "";
        }
        public ThuongHieuDTO(string _math, string _tenth, string _ngaytao, string _ngaycapnhat, string _manhomlk)
        {
            this.Math = _math;
            this.Tenth = _tenth;
            this.Ngaytao = _ngaytao;
            this.Ngaycapnhat = _ngaycapnhat;
            this.Manhomlk = _manhomlk;
        }
    }
}
