using System;
using System.Collections.Generic;
using System.Text;

namespace hotel
{
    class Agenda
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Agenda(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email; 
        }
    }
}
