using Microsoft.EntityFrameworkCore;
using SpukaAp.Models.DTO;
using SpukaAp.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SpukaAp.Models.DataManager
{
    public class AdressenDataManager: IDataRepository2<TAdressen, AdresseListDTo>
    {

        readonly spukaContext _spukaContext;
        public AdressenDataManager(spukaContext spukacontext)
        {
            _spukaContext = spukacontext;
        }

        public IEnumerable<TAdressen> GetAll()    //1
        {
             return _spukaContext.TAdressen
                .Include(adresse => adresse.TBeguenstigte)
                .Include (adresse => adresse.AdrAnredeNavigation)
          
                .ToList();
        }


        public TAdressen Get(string id)   //2
        {


            var adresse = _spukaContext.TAdressen
                 .SingleOrDefault(b => b.AdrAdresse == id);   //String.Equals(author1, author2)    string.Equals(b.AdrAdresse, id)  .Trim()

            return adresse;






        }




        public AdresseListDTo GetDto(string id)   //3
        {
              _spukaContext.ChangeTracker.LazyLoadingEnabled = true;

            using (var context = new spukaContext())
            {

                var adresse = context.TAdressen
                             .SingleOrDefault(b => string.Equals(b.AdrAdresse, id));  //MapToDto
                return MapAdresseToDto.MapToDto(adresse);

            }


            /*  el bueno
            public AdresseDTO GetDto(string id)   //3
        {
              _spukaContext.ChangeTracker.LazyLoadingEnabled = true;
              using (var context = new spukaContext())
              {
                  
            var adresse = context.TAdressen
                         .SingleOrDefault(b => string.Equals(b.AdrAdresse,id));  //MapToDto
                  return AdressenDtoMapper.MapToDto(adresse);

              }  */


            /*   using (var context = new spukaContext () )
             {
                  var query = context.TAdressen
                                     .Where(s => s.AdrAdresse.Equals (id))
                                     .FirstOrDefault<TAdressen>();
                              return AdressenDtoMapper.MapToDto(query);
              } */





        }





        public void Add(TAdressen entity)   //4
        {
            _spukaContext.TAdressen.Add(entity);
            _spukaContext.SaveChanges();
        }

        public void Update(TAdressen entityToUpdate, TAdressen entity)  //5
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TAdressen entity)   //6
        {
            throw new System.NotImplementedException();
        }

    }
}
