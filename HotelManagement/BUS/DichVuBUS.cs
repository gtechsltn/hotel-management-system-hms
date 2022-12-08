﻿using HotelManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    internal class DichVuBUS
    {
        private static DichVuBUS instance;
        public static DichVuBUS Instance
        {
            get { if (instance == null) instance = new DichVuBUS(); return instance; }
            private set { instance = value; }
        }
        private DichVuBUS() { }
        public List<DichVu> GetDichVus()
        {
            return DichVuDAO.Instance.GetDichVus();
        }
        public DichVu FindDichVu(string MaDV)
        {
            return DichVuDAO.Instance.FindDichVu(MaDV);     
        }
    }
}
