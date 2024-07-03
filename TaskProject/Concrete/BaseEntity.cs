using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProject.Abstract;

namespace TaskProject.Concrete
{
    internal class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
