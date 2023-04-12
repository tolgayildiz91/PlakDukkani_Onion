using Microsoft.EntityFrameworkCore;
using PlakDukkani_Onion.Domain.Entities;
using PlakDukkani_Onion.Domain.Repositories;
using PlakDukkani_Onion.Infastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Infastructure.RepositoryConcrete
{
    public class AlbumRepository : BaseRepository<Album>, IAlbumRepository
    {
        PlakDukkaniDbContext _dbContext;
        DbSet<Album> _albumTable;
        public AlbumRepository(PlakDukkaniDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _albumTable = _dbContext.Albums;
        }

        public List<Album> DiscontinuedSale()
        {
            
            return _table.Where(x=>x.SatisDurumu==false && x.Status==Domain.Enums.Status.Active).ToList();
        }

        public List<Album> DiscountedAlbums()
        {
            return _table.Where(x => x.SatisDurumu == true && x.Status == Domain.Enums.Status.Active).ToList();
        }

        public List<Album> LastTenAdded()
        {
            return _table.Where(x => x.SatisDurumu == true).OrderByDescending(x=>x.CreatedDate).Take(10).ToList();
        }

        public List<Album> OngoingSale()
        {
            return _table.Where(x => (x.IndirimOrani != 0 || x.IndirimOrani != null) && x.SatisDurumu == true).OrderByDescending(x => x.IndirimOrani).ToList();
        }
    }
}
