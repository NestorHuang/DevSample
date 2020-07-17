using NUnit.Framework;

namespace DevSample.NUnit.Chapter2.Tests
{
    [TestFixture()]
    public class LogAnalyzerTests
    {
        #region Stage3 將可變動的部分都透過參數傳入，含預期結果
        [TestCase("filewithgoodextension.slf", true)]
        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithbadextension.foo", false)]
        public void IsValidLogFileName_VariousExtensions_ChecksThem(string file, bool expected)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.InValidLogFileName(file);
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Stage2 將預期相同回傳值得透過參數進行測試
        [TestCase("filewithgoodextension.slf")]
        [TestCase("filewithgoodextension.SLF")]
        public void InValidLogFileName_ValidExtensions_ReturnsTrue(string file)
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.InValidLogFileName(file);
            Assert.True(result);
        }
        #endregion

        #region Stage1 根據每個想定去測試
        [Test()]
        public void InValidLogFileName_BadExtension_ReturnsFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.InValidLogFileName("filewithbadextension.foo");
            Assert.False(result);
        }

        [Test()]
        public void IsValidLogFileName_GoodExtension_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.InValidLogFileName("filewithgoodextension.slf");
            Assert.True(result);
        }

        [Test()]
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
        {
            LogAnalyzer analyzer = new LogAnalyzer();
            bool result = analyzer.InValidLogFileName("filewithgoodextension.SLF");
            Assert.True(result);
        }
        #endregion
    }
}