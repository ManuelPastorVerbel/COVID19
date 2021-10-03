using System;
using System.Collections.Generic;

namespace COVID.App.Dominio 
{
    public class CursoEstudiante 
    { 
    public int Estudianteid { get; set; }
    public int Cursoid { get; set; }
    public Estudiante estudiante { get; set; }
    public Curso curso { get; set; }
    }

}