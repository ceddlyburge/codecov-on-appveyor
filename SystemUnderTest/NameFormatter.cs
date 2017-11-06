﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SystemUnderTest
{
    public class NameFormatter
    {
        public string FullName(string firstName, string lastName)
        {
            return $"{lastName}, {firstName}";
        }

        public string FullNameScreamingSnakeCase(string firstName, string lastName)
        {
            return $"{lastName.ToUpperInvariant()}_{firstName.ToUpperInvariant()}";
        }
    }
}
