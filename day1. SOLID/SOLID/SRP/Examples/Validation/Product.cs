using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Examples.Validation
{
  public class Product
  {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public bool IsValid()
    {
      return this.Price > 0;
    }

    // допустим что мы начали пользоваться сервисом который предоставляет скидку 
    // в n-% для продуктов со стоимостью больше 100 единиц. В таком случае нам необходимо
    // обновить метод IsValid
    //public bool IsValid(bool discountService)
    //{
    //  if (discountService)
    //  {
    //    return this.Price > 100;
    //  }
    //  return this.Price > 0;
    //}

    //Solution: переносим логику валидации в другой объект и делаем Product независимым от обьекта валидатора
    // создаем интерфейс IProductvalidator
    //public interface IProductValidator
    //{
    //  bool IsValid(Product product);
    //}

    //public class DefaultProductValidator : IProductValidator
    //{
    //  public bool IsValid(Product product)
    //  {
    //    return product.Price > 0;
    //  }
    //}
  }
}
