using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;

namespace mi_primer_app.Dominio
{
    public class Paciente : Persona
    {
        public string Direccion {get;set}
        public string Ciudad  {get;set}

        public DataTime FechaNacimiento {get;set}

        public Medico Medico {get;set}
        public List<SignoVital> SignosVitales{get;set;}
    }
}