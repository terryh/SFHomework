using System;
using System.Collections.Generic;
using Xunit;

using Homework;

namespace Homework.Tests
{
    public class CharacterizationTest
    {
        private readonly GoodStudentFind _goodStudentFind;
        private readonly List<Student> _students;

        public CharacterizationTest()
        {
            _goodStudentFind = new GoodStudentFind();
            _students = new List<Student>
                {
                    // name, score, bmi
                    new Student("Nick", 95.0f, 22.0f),
                    new Student("Jack", 79.0f, 23.0f),
                    new Student("Clark", 79.0f, 17.0f),
                    new Student("Peter", 82.0f, 17.0f),
                    new Student("John", 80.0f, 26.0f),
                    new Student("Mary", 77.0f, 25.0f),
                };
        }

        [Theory, InlineData("Clark", "NO")]
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

        [Theory, InlineData("Mary", "NO")]
        public void TestCase3(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }
    }

    public class CombinatorialTest
    {
        private readonly GoodStudentFind _goodStudentFind;
        private readonly List<Student> _students;

        public CombinatorialTest()
        {
            _goodStudentFind = new GoodStudentFind();
            _students = new List<Student>
                {
                    // name, score, bmi
                    new Student("Nick", 95.0f, 22.0f),
                    new Student("Jack", 79.0f, 23.0f),
                    new Student("Clark", 79.0f, 17.0f),
                    new Student("Peter", 82.0f, 17.0f),
                    new Student("John", 80.0f, 26.0f),
                    new Student("Mary", 77.0f, 25.0f),
                };
        }

        [Theory, InlineData("Clark", "NO")]
        public void TestCase1(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Peter", "YES")]
        public void TestCase2(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Jack", "YES")]
        public void TestCase3(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Nick", "YES")]
        public void TestCase4(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Mary", "NO")]
        public void TestCase5(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }
        
        [Theory, InlineData("John", "YES")]
        public void TestCase6(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }
        
        [Theory, InlineData("Eric", "")]
        public void TestCase7(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Mike", "")]
        public void TestCase8(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Ted", "")]
        public void TestCase9(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("William", "")]
        public void TestCase10(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Tom", "")]
        public void TestCase11(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Evon", "")]
        public void TestCase12(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }
    }
}
