using System;
using System.Collections.Generic;
using System.Text;

namespace DevSample.CoreVersion.DLLDI.Hello
{
    public class HelloSelector
    {
        private IHello hello;

        public HelloSelector(IHello _hello)
        {
            hello = _hello;
        }

        public void Say()
        {
            hello.SayHello();
        }
    }
}
