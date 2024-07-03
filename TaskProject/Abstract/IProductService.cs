﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProject.Concrete;

namespace TaskProject.Abstract
{
    internal interface IProductService: IBaseService<Product>
    {
        List<Product> GetAllByCategoryId(int categoryId);
    }
}