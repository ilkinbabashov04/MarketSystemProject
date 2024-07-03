using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject.Concrete
{
    internal class User : BaseEntity
    {
        public string Username { get; set; }
        public string Role { get; set; }
    }
}
