using System;
using System.Collections.Generic;

namespace COVID.App.Dominio 
{
    public class CursoProfesor 
    { 
    public int id { get; set; }
   
    public Profesor profesor { get; set; }
    public Curso curso { get; set; }
    }

}