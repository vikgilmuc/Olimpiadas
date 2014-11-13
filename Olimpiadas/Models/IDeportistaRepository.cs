using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas.Models
{
    public interface IDeportistaRepository
    {
        ICollection<Deportista> GetDeportistas(int Dorsal);
    }
}
