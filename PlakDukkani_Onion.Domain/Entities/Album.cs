using PlakDukkani_Onion.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani_Onion.Domain.Entities
{
    public class Album: BaseEntity,IEntity<int>
    {
        public int Id { get; set; }
        public string AlbumAdi { get; set; }
        public string Sanatci { get; set; }
        public DateTime CikisTarihi { get; set; }
        public decimal Fiyat { get; set; }
        public decimal IndirimOrani { get; set; }
        public bool SatisDurumu { get; set; }
       
    }
}
