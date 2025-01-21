using System;
using System.Collections.Generic;

namespace ErrorManagement
{
    public class CustomException
    {
        public void ExceptionCustom()
        {
            // Özel hata sınıfı (Custom Exception) kullanımı.
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            // Action delegasyonu ile profesyonel hata yakalama.
            ActionDelegation.HandleException(() =>
            {
                Find();
            });
        }

        private static void Find()
        {
            List<string> names = new List<string>();
            if (!names.Contains("Batuhan"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }
    }
}