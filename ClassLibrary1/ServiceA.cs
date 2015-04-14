using System;

namespace ClassLibrary1
{
    public class ServiceA
    {
        public void Do()
        {
            Console.WriteLine(typeof(ServiceA).FullName);
        }
    }
}
