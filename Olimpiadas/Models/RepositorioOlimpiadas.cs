using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olimpiadas.Models
{
    public class RepositorioOlimpiadas:IOlimpiadas
    {
        OlimpiadasContext db = new OlimpiadasContext();
        //esto es el contexto 
        Deportista IOlimpiadas.dameDeportistaNuevo()
        {
            return new Deportista();
            
        }

        Deportista IOlimpiadas.dameDeportistaDorsal(int num)
        {
            return db.Deportistas.Find(num);

           
        }

        List<Deportista> IOlimpiadas.dameDeportistas()
        {
            return db.Deportistas.ToList();
        }

        List<Deportista> IOlimpiadas.dameDeportistasDeUnPais(string ISO)
        {
            var resultado = from c in db.Deportistas
                            where c.ISO == ISO
                                select c;
            return resultado.ToList();
        }

        List<Deportista> IOlimpiadas.dameDeportistasMasJovenes(int num)
        {
            var resultado = from c in db.Deportistas where c.edad < num select c;

            return resultado.ToList();
        }

        Pais IOlimpiadas.creaPaisNuevo()
        {
            return new Pais();
        }

        Pais IOlimpiadas.damePais(string ISO)
        {
            return db.Paises.Find(ISO);
        }

        List<Deportista> IOlimpiadas.dameDeporsitasDeUnPaisMenoresDeUnaEdad(string ISO, int edad)
        {
            
            var resultado = from c in db.Deportistas where (c.ISO == ISO )&(c.edad < edad) select c;
            
            return resultado.ToList();
        }

        List<Deportista> IOlimpiadas.dameMedallas(string tipo)
        {
            var resultado = from c in db.Deportistas join  


            throw new NotImplementedException();
        }

        Deportista IOlimpiadas.dameDeportistaClonado(int dorsalviejo)
        {
            throw new NotImplementedException();
        }

        List<DeportistaConPruebas> IOlimpiadas.dameDeportistasConCalificacionesDeUnPais(string ISO)
        {
            throw new NotImplementedException();
        }
    }
}