using TaskProject.Abstract;
using TaskProject.Concrete;

UserCheckRoleManager userCheckRoleManager = new UserCheckRoleManager();

Product product1 = new Product() { Id = 1, CategoryId = 1, ProductName = "Iphone", Description = "256 Gb yaddash", ProductPrice = 1550 };
Product product2 = new Product() { Id = 2, CategoryId = 2, ProductName = "Lenovo", Description = "2 Tb yaddash", ProductPrice = 2500 };


Product product3 = new Product() { Id = 3, CategoryId = 1, ProductName = "Honor", Description = "128 Gb yaddash", ProductPrice = 800 };

Category category1 = new Category() { Id = 1, CategoryName = "Telefonlar" };
Category category2 = new Category() { Id = 2, CategoryName = "Komputerler" };

User user1 = new User() { Id = 1, Username = "Ilkin", Role = "Admin" };
User user2 = new User() { Id = 2, Username = "Kamran", Role = "Seller" };


CategoryManager categoryManager1 = new CategoryManager(userCheckRoleManager, user1);
categoryManager1.Add(category1);
categoryManager1.Add(category2);

Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

CategoryManager categoryManager2 = new CategoryManager(userCheckRoleManager, user2);
categoryManager2.Add(category1);
categoryManager2.Add(category2);

Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

ProductManager productManager1 = new ProductManager(userCheckRoleManager, user1);
productManager1.Add(product1);
productManager1.Add(product2);
productManager1.Add(product3);

Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

ProductManager productManager2 = new ProductManager(userCheckRoleManager, user2);
productManager2.Add(product1);
productManager2.Add(product2);

Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

categoryManager1.Update(category1, "Yeni Telefonlar", 3);
productManager1.Update(product1, "Samsung", 4);

List<Category> allCategories = categoryManager1.GetAll();
foreach(Category category in allCategories)
{
    Console.WriteLine($"Category Name: {category.CategoryName}");
}

Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

List<Product> allProducts = productManager1.GetAll();
foreach (Product product in allProducts)
{
    Console.WriteLine($"Product Name: {product.ProductName}");
}

Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

List<Product> productsByCategoryId = productManager1.GetAllByCategoryId(1);
foreach (Product product in productsByCategoryId)
{
    Console.WriteLine($"Prdoucts: {product.ProductName}");
}

Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

productManager1.Delete(product1);
productManager1.Delete(product2);

Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

categoryManager1.Delete(category1);
categoryManager1.Delete(category2);