using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using COVID.App.Persistencia;
using COVID.App.Dominio;

namespace COVID.App.FrontEnd.pages
{
    public class DetalleModel : PageModel
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());

        public IQueryable<Profesor> Profesor { get; set; }

        //codigo para crear el formulario de filtro de busqueda 
        public void OnGet(int idProfesor)
        {
            //Filtrobusqueda = filtrobusqueda;
            Profesor = _repoProfesor.GetProfesorDetalle(idProfesor);
        }  

        
        
    }
}
