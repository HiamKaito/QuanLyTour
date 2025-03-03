﻿using QuanLyTour.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTour.Models
{
    public class LoaiChiPhiModel
    {
        public string MaLoaiChiPhi { get; set; }
        public string TenLoaiChiPhi { get; set; }
        public static List<LoaiChiPhiModel> GetAll()
        {
            return LoaiChiPhiDAL.getAll();
        }

        public List<LoaiChiPhiModel> getAll()
        {
            return LoaiChiPhiDAL.getAll();
        }

        public bool InserToDB()
        {
            return LoaiChiPhiDAL.Insert(this);
        }

        public bool DeleteToDB()
        {
            return LoaiChiPhiDAL.Delete(this);
        }
        public bool UpdateDB()
        {
            return LoaiChiPhiDAL.Update(this);
        }

        public static int getCount()
        {
            return LoaiChiPhiDAL.getCount();
        }

        public static LoaiChiPhiModel findLCPByID(List<LoaiChiPhiModel> list, string maloai)
        {
            LoaiChiPhiModel res = new LoaiChiPhiModel();

            list.ForEach(x =>
            {
                if (x.MaLoaiChiPhi.Contains(maloai))
                {
                    res.MaLoaiChiPhi = x.MaLoaiChiPhi;
                    res.TenLoaiChiPhi = x.TenLoaiChiPhi;
                }
            });

            return res;
        }
    }
}
