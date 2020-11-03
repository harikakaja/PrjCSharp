using System;

namespace InheritanceEg2
{ 
    class SystemException
    {
        static void Main()
        {
            int num = 30;
            string[] fruits = {"Orange","Mango"};
            int[,] arr = { { 10, 45, 67 }, { 34, 98, 75 } };
            try
            {
                Console.WriteLine("num:[2}",num);
                 Console.WriteLine("Fruit[2]:{0}",fruits[2]);
                num = num / 0;
                int add = 10 + 30;
                Console.WriteLine("addition:{0}", add);
            }
         /*   catch (DivideByZeroException ex)
            {
                Console.WriteLine("Message:{0}", ex);
            }

            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Message:{0}", ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message:{0}",ex.Message);
                Console.WriteLine("Source:{0}", ex.Source);
                Console.WriteLine("Message:{0}", ex.StackTrace);
                Console.WriteLine("Message:Please check the inputs");
            }*/
            finally
            {
                Console.WriteLine("Used to close opened connection");
            }
            num = num * num;
            Console.WriteLine("Multiplication:{0}",num);
            Console.WriteLine("End of Systemexception");
            Console.Read();


        }
    }
}
