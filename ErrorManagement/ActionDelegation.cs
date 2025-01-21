using System;

namespace ErrorManagement
{
    public class ActionDelegation
    {
        // Action delegasyonu ile profesyonel hata yakalama.
        public static void HandleException(Action value) // Merkezi classın içine yazılır.
        {
            try
            {
                value.Invoke(); // Her zaman çalıştır.
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}