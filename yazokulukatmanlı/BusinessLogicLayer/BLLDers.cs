﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayerr;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.DersListesi();
        }
        public static int TalepEkleBLL(EntityBasvuruForm p)
        {
            if(p.BASOGRID!=null && p.BASDERSID != null)
            {
                return DALDers.Talepekle(p);
            }
            return -1;
        }
    }
}
