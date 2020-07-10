using System;
using System.Collections.Generic;
using System.Text;

namespace DevSample.CoreVersion.ModelDI
{
    public class appSettingModel
    {
        public Connectionstring ConnectionString { get; set; }
    }

    public class Connectionstring
    {
        public string ReadOnly { get; set; }
        public string ReadWrite { get; set; }
    }

}
