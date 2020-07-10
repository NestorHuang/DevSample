using System;

namespace DevSample.CoreVersion.DLLDI.Hello
{
    public class EngHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello DI");
        }
    }
}
