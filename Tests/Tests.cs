using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Tests
{
    public class Tests
    {
        [Fact]
        void LastNameCommaFirstName()
        {
            const string FIRST_NAME = "cedd";
            const string LAST_NAME = "cedd";

            var actual = new NameFormatter.FullName(FIRST_NAME, LAST_NAME);

            Assert.Equal($"{LAST_NAME}, {FIRST_NAME}", actual);
        }
    }
}
