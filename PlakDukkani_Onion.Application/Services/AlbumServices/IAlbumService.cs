using PlakDukkani_Onion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Application.Services.AlbumServices
{
    public interface IAlbumService
    {
        void Create(Album album);
        void Edit(Album album);
        void Remove(int id);
        List<Album> GetDefaults(Expression<Func<Album, bool>> expression);
        List<Album> GetAll();
        Album GetById(int id);
        bool IsAlbumExist(string albumName);
        List<Album> DiscontinuedSale();
        List<Album> OngoingSale();
        List<Album> LastTenAdded();
        List<Album> DiscountedAlbums();

    }
}
