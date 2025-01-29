using static Demo.ListGenerators;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicity Type Local Variable [var VS dynamic]
            #region Var 

            ///    var Name = "kermina";
            /// 
            ///    //var Number;==>Invalid =>Must be intialized
            ///    //var Number = null;Invalid =>var can't intialized with null
            ///    Name = null;
            ///   // Name = 10; => Invalid -> After initialzing ,Can't Change the variable DataType 

            #endregion

            #region dynamic
            ///   dynamic Data = "kermina";
            ///   Data = 10;
            ///   Data = null;
            ///   Data = true;
            ///   //Dynamic will escape type checking at Compilation time 
            #endregion

            /// var Employee = new { Id = 10, Name = "kermina", Salary = 8_000 };
            /// dynamic Employee02 = new { Id = 10, Name = "kermina", Salary = 8_000 };
            /// Console.WriteLine(Employee.Id);
            /// Console.WriteLine(Employee02.Id);
            /// //  Console.WriteLine(Employee.Age); ->invalid - > will cause compiler error
            /// Console.WriteLine(Employee02.Age); //will Unhandled exception.


            #endregion

            #region Anonymous Type 
            ///    object emp01 = new { Id = 10, Name = "aa", Salary = 80_000 };
            ///    //Console.WriteLine(emp01.Id) //InValid
            /// 
            ///    var Employee = new { Id = 10, Name = "aa", Salary = 80_000 };
            ///    Console.WriteLine(Employee.Id);
            ///    Console.WriteLine(Employee.GetType().Name);//AnonymousType0`3
            ///    var Employee02 = new { Id = 10, Name = "bb", Salary = 80_000F };
            ///    Console.WriteLine(Employee02.GetType().Name);//AnonymousType0`3
            ///    //The Same Anonymous Type As long AS :
            ///    //1-the same Properties Naming[case Sensitive]
            ///    //2-the same properties
            ///    var Employee03 = new { Id = 10, Salary = 80_000, Name = "kermina" };
            /// 
            ///    Console.WriteLine(Employee03.GetType().Name);//AnonymousType1`3
            ///    var Product = new { ProductId = 100, ProductName = "TEA" };
            ///    Console.WriteLine(Product.GetType().Name);//AnonymousType2`2 
            #endregion

            #region Extenstion Method 
            ///  int X = 12345;
            ///  int Y = IntExtension.Reverse(X);
            ///  Y = X.Reverse();
            ///  Console.WriteLine(Y); 
            #endregion

            #region What's LINQ 

            /// List<int>Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /// List<int>Odds = Numbers.Where(Numbers=>Numbers%2==1).ToList();
            /// Numbers.AddRange([11, 12, 13, 14, 15]);
            /// foreach(int odd in Odds)Console.WriteLine(odd); // 1 3 5 7  9

            ///   List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ///  var Odds = Numbers.Where(Numbers => Numbers % 2 == 1);
            ///   Numbers.AddRange([11, 12, 13, 14, 15]);
            ///   foreach (int odd in Odds) Console.WriteLine(odd); // 1 3 5 7 9 11 13 15  
            #endregion

            #region LINQ Syntax
            #region Fluent Syntax
            /// List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ///  //1.Fluent Syntax
            ///  //1.1 Call "LINQ operator " as static Method Throug Enumrable 
            ///  var OddNumber = Enumerable.Where<int>(Numbers, Numbers => Numbers % 2 == 1);
            ///
            ///  //2.1 call "LINQ Operator " as Extension Mthod
            ///  OddNumber =Numbers.Where(N=>N%2 == 1);
            ///
            ///  foreach(int n in OddNumber) Console.WriteLine(n);
            #endregion

            #region Query Syntax 
            ///   //2.Query Syntax 
            ///   //Query Expression like (Sql Server)
            ///   List<int> Numbers = new List<int>(10) { 1, 2, 3, 4, 5,6,7,8,9};
            ///   var OddNumbers = from N in Numbers
            ///                    where N % 2 == 1
            ///                    select N;
            ///
            ///   foreach(var Odd in OddNumbers) Console.WriteLine(Odd);

            #endregion
            #endregion

            #region LINQ Execution Ways 
            #region Differed Execution 
            /// //Differed Execution (Latest version of Data)
            ///
            /// List<int>Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /// var Result = Numbers.Where(N => N % 2 == 1);
            /// Numbers.AddRange([11, 12, 13, 14, 15]);
            /// foreach(int n in Result) Console.WriteLine(n);//1 3 5 7 9 11 13 15

            #endregion

            #region Immutable Execution 
            /// //Immutable Execution [Element operator , casting Operator , Aggregate Operator ]
            /// List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /// var Result = Numbers.Where(N => N % 2 == 1).ToList();
            /// Numbers.AddRange([11, 12, 13, 14, 15]);
            /// foreach (int n in Result) Console.WriteLine(n);//1 3 5 7 9
            #endregion
            #endregion


            #region Filteration (Restriction) Operators : [Where -OfType]
            ///  var Result = ProductList.Where(p => p.UnitsInStock == 0);
            /// 
            ///  Result = from P in ProductList
            ///           where P.UnitsInStock == 0
            ///         select P;


            /// var Result = ProductList.Where(P => P.UnitsInStock == 0 && P.Category == "Meat/Poultry");
            ///
            ///     Result = from P in ProductList
            ///          where P.UnitsInStock == 0 && P.Category == "Meat/Poultry"
            ///          select P; 

            ///  // Indexed Where
            ///  var Result = ProductList.Where((P, I) => I < 10 && P.UnitsInStock == 0);
            ///  //Indexed Where can't write in Fluent expression Only 

            ///   //OfType
            ///   var Result =ProductList.OfType<Product2>();

            #endregion



            // foreach (var item in Result)Console.WriteLine(item);

        }
    }
}
