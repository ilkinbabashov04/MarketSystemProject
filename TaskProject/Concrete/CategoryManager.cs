using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProject.Abstract;

namespace TaskProject.Concrete
{
    internal class CategoryManager : AbstractCategoryManager
    {
        ICheckRoleService _checkRoleService;
        User user;
        public CategoryManager(ICheckRoleService checkRoleService, User user)
        {
            this._checkRoleService = checkRoleService;
            this.user = user;
        }

        public override void Add(Category category)
        {
            if (_checkRoleService.CheckUserRole(user))
            {
                base.Add(category);
            }
            else
            {
                Console.WriteLine("Bu emeliyyata icazeniz yoxdur");
            }
        }

    }
}
