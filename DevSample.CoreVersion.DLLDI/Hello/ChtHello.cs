using System;

namespace DevSample.CoreVersion.DLLDI.Hello
{
    public class ChtHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("哈囉DI");
        }
    }
}
