using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Classes
{
    public class ActorRole
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public string Actor { get; set; }
        public Movie Movie { get; set; }
    }
}
