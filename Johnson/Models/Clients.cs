using System;
using System.Collections.Generic;

namespace Johnson.Models
{
    public class Clients
    {
        public List<Client> getClientsList()
        {
            return new List<Client>
            {
                new Client { Nom = "Jérémy", Age = 19 },
                new Client { Nom = "Maximilien", Age = 25 },
                new Client { Nom = "David", Age = 42 },
                new Client { Nom = "Corentin", Age = 13 }
            };
        }
    }
}
