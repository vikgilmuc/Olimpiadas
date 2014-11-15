using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Olimpiadas.Models
{
    public class OlimpiadasInitializer : DropCreateDatabaseAlways <OlimpiadasContainer>
    {
        protected override void Seed(OlimpiadasContainer context) {
        
        var Deportistas = new List<Deportista>
        {
            new Deportista {
            
             dorsal = 1,
            nombre = "pepe",

            edad = 35,
             calificacion =6,
            email = "fgdsgg@fsfds.com",
             descripcion ="El mas rapido",
             fechaNacimiento = DateTime.Today,
           ISO = "esp"
    
            
            }
        };

        var Paises = new List<Pais>
        {
            new Pais {
              
                 ISO = "esp",
                 nombre= "españa"
            }
        };




        Paises.ForEach(s => context.Pais.Add(s));
        

        Deportistas.ForEach(s => context.Deportistas.Add(s));
        context.SaveChanges();
        }

    }
}