using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Shared;

namespace Shared.Test
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dnx.html
    public class CalculatorTests
    {
        [Fact]
        public void PassingTest()
        {
            var sut = new Calculator();
            
            var result = sut.Add(2,3);
            
            Assert.Equal(result, 5);
        }
    }
}
