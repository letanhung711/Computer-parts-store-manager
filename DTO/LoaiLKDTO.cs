using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMem_QuanLyKhoLinhKien.DTO
{
    class LoaiLKDTO
    {
        private string _maloai;
        private string _tenloai;
        private string _ngaytao;
        private string _ngaycapnhat;
        private string _manhomlk;

        public LoaiLKDTO()
        {
            this._maloai = "";
            this._tenloai = "";
            this._ngaytao = "";
            this._ngaycapnhat = "";
            this._manhomlk = "";
        }
        public LoaiLKDTO(string _maloai, string _tenloai, string _ngaytao, string _ngaycapnhat, string _manhomlk)
        {
            this._maloai = _maloai;
            this._tenloai = _tenloai;
            this._ngaytao = _ngaytao;
            this._ngaycapnhat = _ngaycapnhat;
            this._manhomlk = _manhomlk;
        }

        public string Maloai
        {
            get
            {
                return _maloai;
            }

            set
            {
                _maloai = value;
            }
        }

        public string Tenloai
        {
            get
            {
                return _tenloai;
            }

            set
            {
                _tenloai = value;
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
    }
}
