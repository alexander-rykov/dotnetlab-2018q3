
namespace AppBll.BusinessModels
{
  public class Discounter: IDiscounter
  {
    public double GetSumOfDiscount(double price)
    {
      if (price > 100)
      {
        return price * 0.10;
      }
      return 0;
    }
  }
}
