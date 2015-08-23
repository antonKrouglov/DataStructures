﻿using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FunctionalTests
{
    [TestClass]
    public sealed class ConcurrentSkipListTests : SkipListTests
    {
        protected internal override SkipList<int> GetCollection()
        {
            return new ConcurrentSkipList<int>();
        }
    }
}
