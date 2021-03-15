using System;
using NUnit.Framework;

namespace WrongFailedTestsCount
{
    [TestFixture]
    public class TestsWithErrorInOneTimeSetup_WithStdOut
    {
        private static int _execCount;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _execCount++;
            Console.Write("TEST OUTPUT WITH NO NEWLINE");
            throw new Exception($"Error in OneTimeSetup. Exec count: {_execCount}");
        }

        [Test]
        public void Test1()
        {
        }

        [Test]
        public void Test2()
        {
        }
    }


    [TestFixture]
    public class TestsWithErrorInSetup_WithStdOut
    {
        private static int _execCount;

        [SetUp]
        public void PerTestSetup()
        {
            _execCount++;
            Console.Write("TEST OUTPUT WITH NO NEWLINE");
            throw new Exception($"Error in PerTestSetup. Exec count: {_execCount}");
        }

        [Test]
        public void Test1()
        {
        }

        [Test]
        public void Test2()
        {
        }
    }


    [TestFixture]
    public class TestsWithErrorInTest_WithStdOut
    {
        private static int _execCount;

        [Test]
        public void Test1()
        {
            _execCount++;
            Console.Write("TEST OUTPUT WITH NO NEWLINE");
            throw new Exception($"Error in Test1. Exec count: {_execCount}");
        }

        [Test]
        public void Test2()
        {
            _execCount++;
            Console.Write("TEST OUTPUT WITH NO NEWLINE");
            throw new Exception($"Error in Test2. Exec count: {_execCount}");
        }
    }
}