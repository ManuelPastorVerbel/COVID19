using System;
using System.Collections.Generic;

namespace COVID.App.Dominio 
{
    public class CursoProfesor 
    { 
    public int Profesorid { get; set; }
    public int Cursoid { get; set; }
    public Profesor profesor { get; set; }
    public Curso curso { get; set; }
    }

}