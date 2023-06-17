using AdwenturesWork;
using AdwenturesWork.Models;

using (AdventureWorks2022Context context = new AdventureWorks2022Context())
{

    foreach (ProductCategory item in context.ProductCategories)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("============================");
    //add
    context.ProductCategories.Add(new ProductCategory() { Name = "Text 3", ModifiedDate = DateTime.Now });
    context.SaveChanges();

    foreach (ProductCategory item in context.ProductCategories)
    {
        Console.WriteLine(item);
    }

    //remove
    int idForRemove = 9;
    context.ProductCategories.Remove(context.ProductCategories.FirstOrDefault(x => x.ProductCategoryId.Equals(idForRemove)));
    context.SaveChanges();
    Console.WriteLine("============================");
    foreach (ProductCategory item in context.ProductCategories)
    {
        Console.WriteLine(item);
    }

    //update
    int idForUpdate = 10;
    var oldData = context.ProductCategories.FirstOrDefault(x => x.ProductCategoryId == idForUpdate);
    oldData.Name = "New Text";
    context.ProductCategories.Update(oldData);
    context.SaveChanges();
    Console.WriteLine("============================");
    foreach (ProductCategory item in context.ProductCategories)
    {
        Console.WriteLine(item);
    }

}