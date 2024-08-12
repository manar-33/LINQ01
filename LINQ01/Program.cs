namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Keywords: Implicitly Typed local variable [var-dynamic]
            #region Var
            //var Data01 = "Manar";
            //Data01 = 2; //Invalid
            //var Data01; //Invalid
            // can not be used as a parameter or return type
            // can not initialized by null 
            #endregion
            #region Dynamic
            //dynamic Data01 = "Manar";
            //Data01 = 22;//Valid
            //Like var in JS
            //CLR will detect datatype at RunTime
            //dynamic X;
            // Console.WriteLine(Data01.GetType().Name);//Int32
            // can be used as a parameter or return type like object
            // Be careful while using dynamic Keyword
            #endregion
            #region Extension Method
            //int Number = 12345;
            //int result=IntExtension.Reverse(Number);
            //Console.WriteLine(result);
            //Number.Reverse();
            #endregion
            #region Anonymous Types
            // Employee Emp01 = new Employee() { Id = 1, Name = "Manar", Salary = 12000 };
            //var Emp01 = new  { Id = 1, Name = "Manar", Salary = 12000 };//Anonymous Type
            //                                                            // var Emp02 = new { Id = 1, Name = "Manar", Salary = 12000 };
            //var Emp02 = Emp01 with { Id = 12 };
            //Console.WriteLine(Emp01);
            //Console.WriteLine(Emp02);
            //Console.WriteLine(Emp01.GetType().Name);//<>f__AnonymousType0`3
            //Console.WriteLine(Emp02.GetType().Name);//<>f__AnonymousType0`3
            #endregion
            #region LINQ
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //var Result = Enumerable.Where(Numbers, N => N % 2 == 0);
            //foreach (var item in Result)
            //{
            //    Console.Write(item+" ");
            //} 
            //LINQ Syntax
            //1.Fluent Syntax

            //List<int> Numbers = new List<int>() { 9, 8, 7, 6, 5, 1, 2, 3, 4 };
            //// var result= Enumerable.Where(Numbers,N=>N%2==0);
            //var result = Numbers.Where(N => N % 2 == 0).ToList();
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}

            //2.Query Syntax Like SQL Style
            //start with from
            //end with select or group by
            //List<int> Numbers = new List<int>() { 9, 8, 7, 6, 5, 1, 2, 3, 4 };
            //var Result = from N in Numbers
            //             where N % 2 == 0
            //             select N;
            //foreach (var item in Result)
            //{
            //    Console.Write(item+" ");
            //}
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = Numbers.Where(N=>N%2==0);
            //Numbers.AddRange([10, 11, 12]);
            //foreach (var item in result)
            //{
            //    Console.Write(item+" ");
            //}

            //Imidiate Way
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var result = Numbers.Where(N => N % 2 == 0).ToList();
            //Numbers.AddRange([10, 11, 12]);
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}
            #endregion
            // ListGenerator.ProductsList
           // Console.WriteLine(ListGenerator.ProductsList[0]);
           // Console.WriteLine(ListGenerator.CustomersList[0]);
        }
    }
}
