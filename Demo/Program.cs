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





        }
    }
}
