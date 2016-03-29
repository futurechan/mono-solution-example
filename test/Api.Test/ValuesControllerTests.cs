using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Api.Controllers;

namespace Api.Test
{
    // see example explanation on xUnit.net website:
    // https://xunit.github.io/docs/getting-started-dnx.html
    public class ValuesControllerTests
    {
        [Fact]
        public void List()
        {
            var sut = new ValuesController();
            var results = sut.Get();
        }
    }
}
