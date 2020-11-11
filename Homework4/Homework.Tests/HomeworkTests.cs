using System;
using System.Collections.Generic;
using Xunit;

using Homework;

namespace Homework.Tests
{
    public class LogicalExpressTest
    {
        private readonly GoodStudentFind _goodStudentFind;
        private readonly List<Student> _students;

        public LogicalExpressTest()
        {
            _goodStudentFind = new GoodStudentFind();
            _students = new List<Student>
                {
                    // name, score, bmi
                    new Student("Nick", 95.0f, 22.0f),
                    new Student("Jack", 79.0f, 23.0f),
                    new Student("John", 80.0f, 26.0f),
                    new Student("Mary", 77.0f, 25.0f),
                };
        }

        // Predicate Coverage 
        [Theory, InlineData("Nick", "YES")]
        public void TestCase1(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Eric", "")]
        public void TestCase2(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        // Clause Coverage 
        [Theory, InlineData("Nick", "YES")]
        public void TestCase3(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Mary", "NO")]
        public void TestCase4(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Eric", "")]
        public void TestCase5(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        // Combinatorial Coverage 
        [Theory, InlineData("Nick", "YES")]
        public void TestCase6(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Jack", "YES")]
        public void TestCase7(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", "YES")]
        public void TestCase8(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Mary", "NO")]
        public void TestCase9(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Eric", "")]
        public void TestCase10(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }
    }
}
