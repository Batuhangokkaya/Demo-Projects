using System;

namespace ErrorManagement
{
    public class ExceptionHandling
    {
        public void HandlingException()
        {
            try
            {
                string[] students = new string[3] { "Batuhan", "Burak", "Yasemin" };
                students[3] = "Azra";
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine("Error Code : {0}", error.Message);
            }
            catch (IndexOutOfRangeException error)
            {
                Console.WriteLine("Error Code : {0}", error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Code : {0}", error.Message);
            }
        }
    }
}