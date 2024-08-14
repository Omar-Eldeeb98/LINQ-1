using System;
using System.Globalization;
using System.Text;

namespace LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // C# keywords : implicit type local variable.
            // var , dynamic

            #region C# keyword - var

            //var Data = "Omar";

            // compiler will detect the data type of variable from it's initial value.
            // we can not use null with var .
            // we can not use var as a parameter or return type in functions.
            //-------------------------------------------------------------
            #endregion

            #region C# keyword - dynamic



            //dynamic data = "omar";

            // like var in javascript.
            // CLR will detect datatype of local variable baes on last value, at runtime.
            // don't need to be initialized
            // can initiazed local variable with null value.
            // can change datatype of local variable after initialization.
            // we can use (dynamic) as parameter or return type in functions.


            //-----------------------------------------------------------------


            /*  data = 10;*/ // valid
            /* data = new StringBuilder("Omar");*/ // valid
            /*  data = new int[3];*/  // valid


            /* dynamic x;*/  // valid

            /*  Console.WriteLine(data.GetType().Name);*/ // String




            #endregion

            #region  Extention Method

            //int number = 12345;

            //var res = IntExtention.reverse(number); // class member method
            //Console.WriteLine(res); // 54321
            //Console.WriteLine("\n");

            //var res2 = number.reverse();
            //Console.WriteLine(res2);  // 54321 , // object member method
            //Console.WriteLine("\n");

            #endregion

            #region Anonymous types

            // anonymous types

            // EX01
            /*  var employee = new { id = 1, name = "omar", salary = 10000 };*/  // anonymous type

            /*Console.WriteLine(employee);*/  // { id = 1, name = omar, salary = 10000 }
            /* Console.WriteLine(employee.GetType().Name);*/ // <>f__AnonymousType0`3

            /* employee.id = 20;*/ // invalid, anonymous types is imutable type "can not change it's value after creation"


            /* var employee2 = employee with { id = 2 };*/ // C# new feature in version 10.0 
                                                           //Console.WriteLine(employee2);  // { id = 2, name = omar, salary = 10000 }
                                                           // Console.WriteLine("\n");




            #endregion


            /*
             -------------------------------------------------------------------------------------------------------
             */


            #region LINQ introduction

            // [LINQ] --> Language Integrated Query
            //      : +40 extention methods "LINQ operators" using against ant data, data in seqence, regardless data store
            //      : 13 category
            //      : LINQ operator exists i class "Enumrable"


            // sequence: object from class implement [IEnumrable] interface.
            // local sequence : L2O, L2XML
            // remote sequence : L2EF --> linq 2 entity framework



            //---------------------------------------------------------------

            // ex
            //List<int> list = new List<int>() {1,2,3,4,5 };
            //var res =  Enumerable.Where(list, n=> n % 2 == 0); // extention method
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            /*    list.Where(n => n % 2 == 0);*/ // also valid




            #endregion

            #region LINQ syntax

            // linq syntax

            //[ 1 - fluent syntax]
            // ---> use linq methods: 1.1 , 1.2

            // linq operators -> (1.1) class member method through class "Enumrable"
            // ex
            //List<int> list = new List<int>() { 1,2,3,7,5,6};
            //var result =  Enumerable.Where(list, n => n % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            //------------------------------------------

            // linq operators -> (1.2)  extention methods through the sequence (recommended)
            // ex
            //var result2 =  list.Where(n => n % 2 == 0);
            // foreach (var item in list)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("\n");

            //------------------------------------------

            //[ 2 - query syntax]
            // ---> like sql style, start with from, end with select or group by
            // query synax is easier than flent sunatx.

            // ex
            //List<int> list = new List<int>() { 1, 2, 3, 7, 5, 6 };

            //var result = from n in list where n % 2 == 0 select n;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}







            #endregion

            #region LINQ Execution Ways

            // linq execution ways:
            //-----------------------------

            // 1 - Differed execution way : 10 category
            // 2 - Immidiate excution way : 3 category [Elements operator, Casting operator, Aggregate operator]

            // [1 - Differed execution example:]

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var res = list.Where(n => n % 2 == 0);  // (Where) is differed (بتتنفذ لما بحناجها فقط)
            //list.AddRange(new int[] { 10,20,30});
            //foreach (var item in res) // Where will execut here
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            //-----------------------------------------------------

            //[2 - Immidiate excution example:]

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //list.AddRange(new int[] { 10, 20, 30 });
            //var res = list.Where(n => n % 2 == 0).ToList();  // Where will execut here , becuase ToList() function
            //foreach (var item in res) 
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            //-----------------------------------------------------

            #endregion

            #region Data Setup

            //Console.WriteLine(ListGenerator.ProductsList[0]);
            //Console.WriteLine(ListGenerator.CustomersList[0]);


            #endregion


        }
    }
}
