using System;
using System.Collections.Generic;
using Xunit;

using Homework;

namespace Homework.Tests
{
    public class StressTest
    {
        private readonly StudentFind _studentFind;
        private readonly List<Student> _students;

        public StressTest()
        {
            _studentFind = new StudentFind();
            _students = new List<Student>
                {
                    new Student("4094W007", "Nick"),
                    new Student("4094W010", "Aven"),
                    new Student("4094W011", "Totti"),
                };

        }

        [Theory, InlineData("Totti", "4094W011")]
        public void TestFound(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", "")]
        public void TestNotFound(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("", "")]
        public void TestCase1(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Fact]
        public void TestCase2()
        {
            Assert.Throws<System.ArgumentException>(() => _studentFind.Find("JohnJohnJohnJohnJohnJohnJohnJohnJohnJohn", _students));
        }

        [Theory, InlineData("Hello 0002", "")]
        public void TestCase3(string name, string expectValue)
        {

            List<Student> _noStudents = new List<Student>();
            var result = _studentFind.Find(name, _noStudents);
            Assert.Equal(result, expectValue);
        }

        [Fact]
        public void TestCase4()
        {
            List<Student> _manyStudents = new List<Student>();
            for (var i = 1; i <= 600; i++)
            {
                _manyStudents.Add(new Student($"ST{i:0000}", $"Hello {i:0000}"));
            }
            Assert.Throws<System.ArgumentException>(() => _studentFind.Find("Hello 0002", _manyStudents));
        }
    }
}
