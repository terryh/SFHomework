using System;
using System.Collections.Generic;
using Xunit;

using Homework;

namespace Homework.Tests
{
    public class InputDomainCharacterizationTest
    {
        private readonly GoodStudentFind _goodStudentFind;
        private readonly List<Student> _students;

        public InputDomainCharacterizationTest()
        {
            _goodStudentFind = new GoodStudentFind();
            _students = new List<Student>
                {
                    // name, score, bmi
                    new Student("Nick", 95.0f, 22.0f),
                    new Student("Jack", 79.0f, 18.0f),
                    new Student("John", 80.0f, 26.0f),
                    new Student("Mary", 77.0f, 25.0f),
                };
        }

        //  Combinatorial Coverage
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
        [Theory, InlineData("Jack", "NO")]
        public void TestCase3(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", "YES")]
        public void TestCase4(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

    }
}
