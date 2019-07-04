using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventSocialProject.Models.DatabaseTables
{
    public class Gosteri
    {
        public int GosteriID { get; set; }

        public string GonderiAciklama { get; set; }

        public byte[] GonderiGorsel { get; set; }

        public Uye UyeID { get; set; }


    }
}