using SpukaAp.Models.DTO;
using SpukaAp.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SpukaAp.Models.DataManager
{
    public class BeguenstigteDataManager : IDataRepository<TBeguenstigte, BeguenstigteDTO>
    {

        readonly spukaContext _spukaContext;

        public BeguenstigteDataManager (spukaContext spukacontext)

        {
            _spukaContext = spukacontext;

        }
        public void Add(TBeguenstigte entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TBeguenstigte entity)
        {
            throw new NotImplementedException();
        }

        public TBeguenstigte Get(int id)  //2
        {
            var beguenstigte = _spukaContext.TBeguenstigte
                .SingleOrDefault(b => b.BegStatus == id);

            return beguenstigte;
        }

        public IEnumerable<TBeguenstigte> GetAll()  //1
        {
            throw new NotImplementedException();
        }

        public BeguenstigteDTO GetDto(int id)  //3
        {
            _spukaContext.ChangeTracker.LazyLoadingEnabled = true;

            using (var context = new spukaContext())
            {
                var beguenstigte = context.TBeguenstigte
                       .SingleOrDefault(b => b.BegStatus == id);
                return BeguenstigteDtoMapper.MapToDto(beguenstigte);
            }
        }

        public void Update(TBeguenstigte entityToUpdate, TBeguenstigte entity)
        {
            throw new NotImplementedException();
        }
    }
}
