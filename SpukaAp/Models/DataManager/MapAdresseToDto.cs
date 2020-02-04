using SpukaAp.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpukaAp.Models.DataManager
{
    public class MapAdresseToDto
    {
       
        

                public static AdresseListDTo MapToDto(TAdressen adresse)
                {
            return new AdresseListDTo()

            {
                AdrAdresse = adresse.AdrAdresse,
                AdrMandant = adresse.AdrMandant,
                AdrVorname = adresse.AdrVorname,
                AdrName = adresse.AdrName,
                AdrTitel = adresse.AdrTitel,
                AdrStrasse = adresse.AdrStrasse,
                AdrPlz = adresse.AdrPlz,
                AdrOrt = adresse.AdrOrt,
                AdrAnrede = adresse.AdrAnrede,
                AdrGdatum = adresse.AdrGdatum,
                AdrTyp = adresse.AdrTyp,
                Salutation = new TAnrede()

                {
                    AnrAnredeId = adresse.AdrAnredeNavigation.AnrAnredeId,
                    AnrAnrede = adresse.AdrAnredeNavigation.AnrAnrede,
                    AnrJnperson = adresse.AdrAnredeNavigation.AnrJnperson


                },

                Beguenstigte = adresse.TBeguenstigte.Select(x => new BeguenstigteDTO

                {
                    BegBeguenstigter = x.BegBeguenstigter,
                    BegMitglied = x.BegMitglied,
                    BegAdresse = x.BegAdresse,
                    BegStatus = x.BegStatus,
                    BegPersonalNr = x.BegPersonalNr,
                    BegEintrittsdatum = x.BegEintrittsdatum



                })

                .ToList()




            };

                }


    }
}
