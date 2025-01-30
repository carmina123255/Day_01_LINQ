using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;
using static Assignment.ListGenerator;
namespace Assignment
{
    class CaseSensitive : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            x = x?.ToLower();
            y = y?.ToLower();
            return x.CompareTo(y);

        }
    }
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

            #region Q03
            ///3. Returns digits whose name is shorter than their value.
            ///

            ///  string[] Arr = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            ///
            ///  var Result = Arr.Where((P, Index) => P.Length < Index);
            ///
            ///
            ///  foreach (var P in Result) Console.WriteLine(P); 
            #endregion

            #endregion


            #region Part02 

            #region Q01
            ///Sort a list of products by name
            ///

            ///  var Result = ProductList.OrderBy(P => P.ProductName);
            ///
            ///  Result =from P in ProductList
            ///          orderby P.ProductName
            ///          select P;   
            ///
            ///  foreach (var result in Result) Console.WriteLine(result); 
            #endregion

            #region Q02 
            ///  Uses a custom comparer to do a case -insensitive sort of the words in an array.
            ///  

            ///   string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            /// 
            ///   
            ///   var Result= Arr.OrderBy(X=>X, new CaseSensitive());
            /// 
            ///   Result = from P in Arr
            ///            orderby P.ToLower()
            ///            select P;
            ///             
            ///   foreach(var X in Result) Console.WriteLine(X);



            #endregion

            #region Q03 
            ///3. Sort a list of products by units in stock from highest to lowest.
            ///

            ///   var Result = ProductList.OrderByDescending(P => P.UnitsInStock);
            ///
            ///   Result =from P in ProductList
            ///           orderby P.UnitsInStock descending
            ///           select P;   
            ///
            ///   foreach(var result in Result) Console.WriteLine(result); 
            #endregion

            #region Q04 
            ///4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            ///

            ///    string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ///    var Result = Arr.OrderBy(A => A.Length).ThenBy(P=>P);
            /// 
            ///    Result = from P in Arr
            ///             orderby P.Length, P
            ///             select P;
            /// 
            ///    foreach (var A in Result) Console.WriteLine(A);
            ///   
            #endregion

            #region Q05 
            ///5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            ///


            ///   string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ///  
            ///   var Result = words.OrderBy(X=>X.Length).ThenBy(x=>x,StringComparer.OrdinalIgnoreCase);
            ///
            ///   Result = from P in words
            ///            orderby P.Length, P.ToLower()
            ///            select P; 
            ///   
            ///   foreach (var result in Result) Console.WriteLine(result); 
            #endregion

            #region Q06 
            ///6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            ///    var Result = ProductList.OrderByDescending(X => X.Category).ThenByDescending(X => X.UnitPrice);
            ///
            ///    Result = from P in ProductList
            ///             orderby P.Category descending,P.UnitPrice descending
            ///             select P;
            ///
            ///    foreach (var P in Result) Console.WriteLine(P); 
            #endregion

            #region Q07 

            /// 7.Sort first by word length and then by a case -insensitive descending sort of the words in an array.
            /// 


            ///   string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            ///
            ///   var Result = Arr.OrderBy(X => X.Length).ThenByDescending(X => X, new CaseSensitive());
            ///
            ///   Result = from P in Arr
            ///             orderby P.Length, P.ToLower() descending
            ///             select P; 
            ///    
            ///   foreach (var x in Result) Console.WriteLine(x); 
            #endregion

            #region Q 08 
            ///8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order 
            ///in the original array.

            ///   string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            ///   var Result = Arr.Where(X => X.Length > 1 && X[1] == 'i').Reverse();
            ///
            ///   Result = (from P in Arr
            ///             where P.Length > 0 && P[1] == 'i'
            ///             select P).Reverse();
            /// 

            /// foreach (var X in Result) Console.WriteLine(X);
            #endregion

            #endregion

            #region Part03 

            #region Q01 
            ///. Return a sequence of just the names of a list of products.
            ///

            /// var Result = ProductList.Select(X => X.ProductName);
            ///
            /// Result = from P in ProductList
            ///          select P.ProductName;
            ///
            /// foreach (var P in Result) Console.WriteLine(P); 
            #endregion

            #endregion
        }
    }
}
