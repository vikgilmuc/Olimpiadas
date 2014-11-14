using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olimpiadas.Models
{
    public class RepositorioOlimpiadas:IOlimpiadas
    {
        OlimpiadasContainer db = new OlimpiadasContainer();
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
            if (num != 0)
            {

                var resultado = from c in db.Deportistas orderby c.edad descending select c;

                return resultado.Take(num).ToList();
            }
            else
            {
                return (from c in db.Deportistas orderby c.edad descending select c).ToList();
            }
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
            
            var resultado = from c in db.Deportistas where (c.ISO == ISO )&&(c.edad < edad) select c;
            
            return resultado.ToList();
        }

       List<Deportista> IOlimpiadas.dameMedallas(string tipo)

        {
         int pos = -1;
         if (tipo.ToUpper().Equals("ORO"))
            {
            pos = 1;
            }
             if (tipo.ToUpper().Equals("PLATA"))
            {
            pos = 2;
            }
             if (tipo.ToUpper().Equals("BRONCE"))
            {
            pos =3;
            }

             var resultado = from c in db.Deportistas // Lista de clientes
             join p in db.Calificaciones on c.dorsal equals p.dorsal // Equivale al INNER JOIN TABLA2 ON TABLA1.ID_PK = TABLA2.ID_FK
             where p.posicion==pos
             select c;
         return resultado.ToList();
        }



        Deportista IOlimpiadas.dameDeportistaClonado(int dorsalviejo)
        {
            Deportista miDeportistaNuevo = null;

           Deportista miDeportista = db.Deportistas.Find(dorsalviejo);

            if (miDeportista != null)
            {

                miDeportistaNuevo = new Deportista();

                miDeportistaNuevo.edad = miDeportista.edad;

                miDeportistaNuevo.ISO = miDeportista.ISO;

                miDeportistaNuevo.nombre = miDeportista.nombre;

            }

            return miDeportistaNuevo;
        }

        List<DeportistaConPruebas> IOlimpiadas.dameDeportistasConCalificacionesDeUnPais(string ISO)
        {


            List<DeportistaConPruebas> miAux = new List<DeportistaConPruebas>();

            List<Deportista> listaDeportistas = new List<Deportista>();

            listaDeportistas = db.Deportistas.ToList();

            foreach (Deportista miDeportista in listaDeportistas)
            {

                DeportistaConPruebas miAtleta = new DeportistaConPruebas();

                miAtleta.deportista = miDeportista;

                miAtleta.PruebasPosiciones = damePosicionesDeDeportista(miDeportista.dorsal);

                miAux.Add(miAtleta);

            }

            return miAux;
           




        }

         private List<PruebaPosicion> damePosicionesDeDeportista(int dorsal)

            {

             List<PruebaPosicion> Aux = new List<PruebaPosicion>();

             var resultado = from p in db.Pruebas // Lista de clientes

             join c in db.Calificaciones on p.Id equals c.idPrueba // Equivale al INNER JOIN TABLA2 ON TABLA1.ID_PK = TABLA2.ID_FK

             where c.dorsal == dorsal && c.posicion < 4

             select c;

             foreach(Calificaciones calificacion in resultado)

                {

                 Prueba miPrueba = db.Pruebas.Find(calificacion.idPrueba);

                 PruebaPosicion miPruebaPosicion = new PruebaPosicion();

                miPruebaPosicion.nombrePrueba = miPrueba.nombre;

                miPruebaPosicion.posicion = calificacion.posicion;

                Aux.Add(miPruebaPosicion);

              }

             return Aux;

            }


    }
}