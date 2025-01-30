﻿using System.Collections.Immutable;
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

            /// string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            /// Array.Sort(Arr, new CaseSensitive());
            /// 
            /// foreach (string str in Arr) Console.WriteLine(str);
            ///  
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
            #endregion
        }
    }
}
