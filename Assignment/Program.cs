using System.Runtime.ConstrainedExecution;
using static Assignment.ListGenerator;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01 

            #region Q1 
            ///Find all products that are out of stock.
            ///

            ///   var Result = ProductList.Where(P => P.UnitsInStock == 0);
            ///
            ///   Result = from p in ProductList
            ///            where p.UnitsInStock == 0
            ///            select p;
            ///
            ///   foreach (var item in Result) Console.WriteLine(item); 
            #endregion

            #region  Q2 
            ///. Find all products that are in stock and cost more than 3.00 per unit.
            ///

            ///   var Result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00M);
            ///
            ///   Result = from P in ProductList
            ///            where P.UnitsInStock > 0 && P.UnitPrice > 3.00M
            ///            select P;
            ///
            ///   foreach(var P in Result) Console.WriteLine(P); 
            #endregion

            #endregion
        }
    }
}
