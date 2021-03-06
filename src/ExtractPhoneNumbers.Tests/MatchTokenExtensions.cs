﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractPhoneNumbers.Tests
{
    public static class MatchTokenExtensions
    {
        public static string JoinToString(this IEnumerable<MatchToken> matchTokens)
        {
            return String.Join("", matchTokens.Select(t => t.Value).ToArray());
        }

        public static string JoinToString(this IEnumerable<TestCase> failures)
        {
            return String.Join(Environment.NewLine,failures.Select(f=>f.Key));
        }
    }
}
