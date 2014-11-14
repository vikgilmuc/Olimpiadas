using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas.Models
{
    public interface IOlimpiadas
    {

         Deportista dameDeportistaNuevo();
         Deportista dameDeportistaDorsal(int num);
         List<Deportista> dameDeportistas();
         List<Deportista> dameDeportistasDeUnPais(String ISO);
         List<Deportista> dameDeportistasMasJovenes (int num=0);
         Pais creaPaisNuevo();
         Pais damePais(String ISO);
         List<Deportista> dameDeporsitasDeUnPaisMenoresDeUnaEdad(String ISO, int edad= 1000);
         List<Deportista> dameMedallas(String tipo);

         Deportista dameDeportistaClonado(int dorsalviejo);

         List<DeportistaConPruebas> dameDeportistasConCalificacionesDeUnPais(string ISO);

    }
}
