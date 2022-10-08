using  System;

namespace error_management
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entered number:"+num);

            }
            catch(Exception ex)
            {
                Console.WriteLine("Error:"+ex.Message.ToString());

            }
            finally
            {
                Console.WriteLine("Completed");

            }

            try
            {
                //int a = int.Parse(null);

                //int a = int.Parse("test");
                int a = int.Parse("-2000000000000000");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("You Entered Null!");
                throw;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Data type is not correct!");
                throw;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Overflow max or min value!");
                throw;

            }

            finally
            {
                Console.WriteLine("Your task completed successfully!");
            }



        }
    }
}
