using System;
using System.Collections.Generic;
using Xunit;

using Homework;

namespace Homework.Tests
{
    public class EdgeCoverageTest
    {
        private readonly StudentFind _studentFind;
        private readonly List<Student> _students;

        public EdgeCoverageTest()
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
        public void TestCase1(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", "")]
        public void TestCase2(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }
    }

    public class EdgePairCoverageTest
    {
        private readonly StudentFind _studentFind;
        private List<Student> _students;

        public EdgePairCoverageTest()
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
        public void TestCase1(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", "")]
        public void TestCase2(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", "")]
        public void TestCase3(string name, string expectValue)
        {
            List<Student> _emptyStudents = new List<Student> { };
            var result = _studentFind.Find(name, _emptyStudents);
            Assert.Equal(result, expectValue);
        }
    }

    public class TestPathCoverageTest
    {
        private readonly StudentFind _studentFind;
        private List<Student> _students;

        public TestPathCoverageTest()
        {
            _studentFind = new StudentFind();
            _students = new List<Student>
                {
                    new Student("4094W007", "Nick"),
                    new Student("4094W010", "Aven"),
                    new Student("4094W011", "Totti"),
                };

        }

        [Theory, InlineData("", "")]
        public void TestCase1(string name, string expectValue)
        {
            List<Student> _emptyStudents = new List<Student> { };
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Nick", "4094W007")]
        public void TestCase2(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Aven", "4094W010")]
        public void TestCase3(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", "")]
        public void TestCase4(string name, string expectValue)
        {
            var result = _studentFind.Find(name, _students);
            Assert.Equal(result, expectValue);
        }
    }

}