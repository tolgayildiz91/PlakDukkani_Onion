using PlakDukkani_Onion.Domain.Entities;
using PlakDukkani_Onion.Infastructure.RepositoryConcrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Application.Services.AlbumServices
{
    public class AlbumService:IAlbumService
    {
        public AlbumService(AlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }
        AlbumRepository _albumRepository;

        public  void Create(Album album)
        {
            _albumRepository.Add(album);
        }

        public void Edit(Album album)
        {
            _albumRepository.Update(album);
        }

        public void Remove(int id)
        {
            Album album = _albumRepository.GetBy(x => x.Id == id);
            _albumRepository.Delete(album);
        }

        public List<Album> GetDefaults(Expression<Func<Album, bool>> expression)
        {   
            return _albumRepository.GetDefault(expression);
        }

        public List<Album> GetAll()
        {
            return _albumRepository.GetAll();
        }

        public Album GetById(int id)
        {
            return _albumRepository.GetBy(x => x.Id == id);
        }

        public bool IsAlbumExist(string albumName)
        {
            throw new NotImplementedException();
        }

        public  List<Album> DiscontinuedSale()
        {
            return _albumRepository.DiscontinuedSale();
        }

        public  List<Album> OngoingSale()
        {
            return  _albumRepository.OngoingSale();
        }

        public  List<Album> LastTenAdded()
        {
            return  _albumRepository.LastTenAdded();
        }

        public  List<Album> DiscountedAlbums()
        {
            return  _albumRepository.DiscountedAlbums();
        }
    }
}
