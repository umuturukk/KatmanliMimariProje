﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccesLayer;

namespace BusinessLayer
{
    public class BLOgrenci
    {
        public static int OgrenciEkleBL(EntityOgrenci p)
        {
            if (p.Ad != "" && p.Ad.Length >= 2 && p.Ad.Length <= 30 && p.Soyad != "" && p.Bolum !="" && p.Numara.Length == 5)
            {
                return DalOgrenci.OgrenciEkle(p);
            }
            return -1;
        }
        public static List<EntityOgrenci> OgrenciListesiBL()
        {
            return DalOgrenci.OgrenciListesi();
        }
        public static int OgrenciSilBL(int p)
        {
            if(p >= 1)    
                return DalOgrenci.OgrenciSil(p);
           
            else        
                return -1;     
        }
        public static int OgrenciGuncelleBL(EntityOgrenci p)
        {
            if (p.Ad != null && p.Soyad != "" && p.Numara.Length == 5 && p.Bolum != "" && p.Bolum.Length >= 3 && p.Bolum.Length <= 30)
            {
                return DalOgrenci.OgrenciGuncelle(p);
            }
            return -1;
        }

    }
}
