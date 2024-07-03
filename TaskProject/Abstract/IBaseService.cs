using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject.Abstract
{
    internal interface IBaseService<T> where T : class, IEntity
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t, string newName, int newID);
        List<T> GetAll();
    }
}
