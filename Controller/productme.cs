

using Microsoft.AspNetCore.Mvc;


[Route("[Action]")]
[ApiController]

public class Productme:Controller
{

    Context db=new Context();


    [HttpPost]
    public string insert(Product x)
    {
        db.Tbl_Product.Add(x);
        db.SaveChanges();

        return "done";

    }


    [HttpGet]

    public List<Product> GetAll()
    {
        return db.Tbl_Product.ToList();
    }


    [HttpDelete]
    public string Delete(int Id)
    {
        var x=db.Tbl_Product.Find(Id);
        db.Tbl_Product.Remove(x);
        db.SaveChanges();
         return "Done";
    }

    [HttpPut]
    public string Update(Product x)
    {
         var result=db.Tbl_Product.Find(x.Id);
         result.Name=x.Name;
         result.Price=x.Price;

         db.Tbl_Product.Update(result);
         db.SaveChanges();

         return "Done";

    }




    

}