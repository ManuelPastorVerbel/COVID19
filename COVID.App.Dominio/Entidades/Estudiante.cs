using System;

namespace COVID.App.Dominio
{
    public class Estudiante : Persona
    {
        public string carrera { get; set; }
        public int semestre { get; set;}
        public System.Collections.Generic.List<CursoEstudiante> cursoestudiante { get; set; }
        
    }
}