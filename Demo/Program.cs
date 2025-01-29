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



        }
    }
}
