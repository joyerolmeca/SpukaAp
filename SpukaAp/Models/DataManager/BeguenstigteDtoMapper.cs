using SpukaAp.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpukaAp.Models.DataManager
{
    public class BeguenstigteDtoMapper
    {
        public static BeguenstigteDTO MapToDto(TBeguenstigte beguenstigte)


        {
            return new BeguenstigteDTO()
            {
                BegBeguenstigter = beguenstigte.BegBeguenstigter,
                BegMitglied = beguenstigte.BegMitglied,
                BegAdresse= beguenstigte.BegAdresse,
                BegStatus= beguenstigte.BegStatus,
                BegPersonalNr= beguenstigte.BegPersonalNr,
                BegEintrittsdatum= beguenstigte.BegEintrittsdatum
            };
        }

    }
}
