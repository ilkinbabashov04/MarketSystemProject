using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskProject.Concrete;

namespace TaskProject.Abstract
{
    internal class AbstractCategoryManager : ICategoryService
    {
        private readonly List<Category> _categories;

        public AbstractCategoryManager()
        {
            this._categories = new List<Category>();
        }
        public virtual void Add(Category category)
        {
            _categories.Add(category);
            Console.WriteLine("Kateqoriya ugurla elave edildi");
        }

        public void Delete(Category category)
        {
            foreach (Category item in _categories)
            {
                if(item.Id == category.Id)
                {
                    category = item;
                    break;
                }
            }
            if(category != null)
            {
                _categories.Remove(category);
                Console.WriteLine($"{category.CategoryName} kateqoriyasi ugurla silindi");
            }
            else
            {
                Console.WriteLine("Bele bir mehsul yoxdur...");
            }
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category category, string newName, int newID)
        {
            foreach(Category item in _categories)
            {
                if(item.Id == category.Id)
                {
                    category = item;
                    break;
                }
            }
            if(category != null)
            {
                category.Id = newID;
                category.CategoryName = newName;
                Console.WriteLine($"Yeni id: {category.Id}, yeni CategoryName: {category.CategoryName}");
            }
            else
            {
                Console.WriteLine("Bele bir mehsul yoxdur.");
            }
        }
    }
}
