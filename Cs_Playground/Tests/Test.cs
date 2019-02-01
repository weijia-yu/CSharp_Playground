using System;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace Cs_Playground.Tests
{
    
    public class Test
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1,1);
        }
        [Test]
        public async Task TestAsync() {
            int i = await MainClass.ReturnIntAsync();
            Assert.AreEqual(i,0);
        }
    }
}
