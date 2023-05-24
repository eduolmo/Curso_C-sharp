using System;

namespace Enumeracao.Entities
{
    internal class Client
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.BirthDate.ToString("dd/MM/yyyy")} - {this.Email}";
        }
    }
}
