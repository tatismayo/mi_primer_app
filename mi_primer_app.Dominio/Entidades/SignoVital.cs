using System;

namespace mi_primer_app.Dominio
{
    public class SignoVital
    {
        public int Id {get; set}

        public DateTime FechaHora {get; set}

        public float Valor {get; set}

        public TipoSigno Signo {get; set}

        public Paciente Paciente {get; set}
    }
}