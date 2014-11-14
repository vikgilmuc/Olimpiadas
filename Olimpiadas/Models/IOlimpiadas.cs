using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olimpiadas.Models
{
    interface IOlimpiadas
    {

        public Deportista dameDeportistaNuevo();
        public Deportista dameDeportistaDorsal(int num);
        public List<Deportista> dameDeportistas();
        public List<Deportista> dameDeportistasDeUnPais(String ISO);
        public List<Deportista> dameDeportistasMasJovenes (int num=0);
        public Pais creaPaisNuevo();
        public Pais damePais(String ISO);
        public List<Deportista> dameDeporsitasDeUnPaisMenoresDeUnaEdad(String ISO, int edad= 1000);
        public List<Deportista> dameMedallas(String tipo);

        public Deportista dameDeportistaClonado(int dorsalviejo);

        public List<DeportistaConPruebas> dameDeportistasConCalificacionesDeUnPais(string ISO);

    }
}
