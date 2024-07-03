using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProject.Abstract;

namespace TaskProject.Concrete
{
    internal class ProductManager : AbstractProductManager
    {
        ICheckRoleService _roleService;
        User user;
        public ProductManager(ICheckRoleService checkRoleService, User user)
        {
            this._roleService = checkRoleService;
            this.user = user;
        }
        public override void Add(Product product)
        {
            if (_roleService.CheckUserRole(user))
            {
                base.Add(product);
            }
            else
            {
                Console.WriteLine("Bu shexsin bu emeliyyata icazesi yoxdur");
            }
        }
    }
}
