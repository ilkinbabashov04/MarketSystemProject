using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProject.Abstract;

namespace TaskProject.Concrete
{
    internal class UserCheckRoleManager : ICheckRoleService
    {
        enum RoleName
        {
            Admin,
            Cashier,
            Seller
        }
        public bool CheckUserRole(User user)
        {
            if(RoleName.Admin.ToString() == user.Role || RoleName.Cashier.ToString() == user.Role)
                return true;
            else return false;
        }
    }
}
