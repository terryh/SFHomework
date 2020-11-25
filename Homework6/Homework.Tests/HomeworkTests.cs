using System;
using System.Collections.Generic;
using Xunit;

using Homework;

namespace Homework.Tests
{
    public class MutationTest
    {
        private readonly GoodStudentFind _goodStudentFind;
        private readonly List<Student> _students;

        public MutationTest()
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

        [Theory, InlineData("John", "YES")]
        public void TestCase1(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", "")]
        public void TestCaseLine1(string name, string expectValue)
        {
            var _goodStudentFindMuted = new GoodStudentFindLine1();
            var result = _goodStudentFindMuted.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", "YES")]
        public void TestCase2(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", "NO")]
        public void TestCaseLine2(string name, string expectValue)
        {
            var _goodStudentFindMuted = new GoodStudentFindLine2();
            var result = _goodStudentFindMuted.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Nick", "YES")]
        public void TestCase3(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Nick", "NO")]
        public void TestCaseLine3(string name, string expectValue)
        {
            var _goodStudentFindMuted = new GoodStudentFindLine3();
            var result = _goodStudentFindMuted.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Mary", "NO")]
        public void TestCase4(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Mary", "NO")]
        public void TestCaseLine4(string name, string expectValue)
        {
            var _goodStudentFindMuted = new GoodStudentFindLine4();
            var result = _goodStudentFindMuted.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Mary", "NO")]
        public void TestCase5(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Mary", "YES")]
        public void TestCaseLine5(string name, string expectValue)
        {
            var _goodStudentFindMuted = new GoodStudentFindLine5();
            var result = _goodStudentFindMuted.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Eric", "")]
        public void TestCase6(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("Eric", "YES")]
        public void TestCaseLine6(string name, string expectValue)
        {
            var _goodStudentFindMuted = new GoodStudentFindLine6();
            var result = _goodStudentFindMuted.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

    }
}
