using System;

namespace Core
{
    public class Logger
    {
        public void LogInformation(string info)
        {
            if (info == null) throw new ArgumentNullException(nameof(info));
            Console.WriteLine(info);
            Console.WriteLine("Executado com sucesso");
        }
    }
}