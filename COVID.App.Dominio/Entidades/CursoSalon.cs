using System;
using System.Collections.Generic;

namespace COVID.App.Dominio 
{
    public class CursoSalon 
    { 
    public int Salonid { get; set; }
    public int Cursoid { get; set; }
    public Salon salon { get; set; }
    public Curso curso { get; set; }
    }

}