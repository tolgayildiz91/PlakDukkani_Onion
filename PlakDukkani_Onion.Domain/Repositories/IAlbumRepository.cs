using PlakDukkani_Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Domain.Repositories
{
    public interface IAlbumRepository:IBaseRepository<Album>
    {
        List<Album> DiscontinuedSale();
        List<Album> OngoingSale();
        List<Album> LastTenAdded();
        List<Album> DiscountedAlbums();

    }
}
