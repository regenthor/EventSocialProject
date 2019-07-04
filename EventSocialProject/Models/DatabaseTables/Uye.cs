using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventSocialProject.Models.DatabaseTables
{
    public class Uye
    {
        public int uyeID { get; set; }

        public string uyeAd { get; set; }

        public string uyeSoyad { get; set; }

        public DateTime uyeDTarih { get; set; }

        public string uyeTel { get; set; }

        public string uyeMail { get; set; }

        public string uyeSifre { get; set; }


    }
}