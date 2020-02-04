using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpukaAp.Models.DTO
{
    public class BeguenstigteDTO
    {

        public BeguenstigteDTO ()
        {

        }

        public string BegBeguenstigter { get; set; }
        public string BegMitglied { get; set; }
        public string BegAdresse { get; set; }
        public int BegStatus { get; set; }
        public string BegPersonalNr { get; set; }
        public DateTime? BegEintrittsdatum { get; set; }



    }


}
