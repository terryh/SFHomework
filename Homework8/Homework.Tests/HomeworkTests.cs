using System;
using System.Collections.Generic;
using Xunit;

using Homework;

namespace Homework.Tests
{
    public class BoundaryValueTest
    {
        private readonly StudentScore _studentScore;
        private readonly List<Student> _students;

        public BoundaryValueTest()
        {
            _studentScore = new StudentScore();
            _students = new List<Student>
                {
                    new Student("4094W020"),
                    new Student("4094W021"),
                };
        }

        [Fact]
        public void TestCase1()
        {
            List<Student> _noStudents = new List<Student>();
            Assert.Throws<System.ArgumentException>(() => _studentScore.SetStudentScore("4094W020", 99, _noStudents));
        }

        [Theory, InlineData("4094W020", 99, true)]
        public void TestCase2(string id, int score, bool expectValue)
        {

            List<Student> _oneStudents = new List<Student>
                {
                    new Student("4094W020"),
                };

            bool result = _studentScore.SetStudentScore(id, score, _oneStudents);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("4094W020", 99, true)]
        public void TestCase3(string id, int score, bool expectValue)
        {
            bool result = _studentScore.SetStudentScore(id, score, _students);
            Assert.Equal(result, expectValue);
        }


        [Theory, InlineData("ST0100", 99, true)]
        public void TestCase4(string id, int score, bool expectValue)
        {
            List<Student> _manyStudents = new List<Student>();
            for (var i = 1; i < 500; i++)
            {
                _manyStudents.Add(new Student($"ST{i:0000}"));
            }
            bool result = _studentScore.SetStudentScore(id, score, _manyStudents);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("ST0100", 99, true)]
        public void TestCase5(string id, int score, bool expectValue)
        {
            List<Student> _manyStudents = new List<Student>();
            for (var i = 1; i <= 500; i++)
            {
                _manyStudents.Add(new Student($"ST{i:0000}"));
            }
            bool result = _studentScore.SetStudentScore(id, score, _manyStudents);
            Assert.Equal(result, expectValue);
        }

        [Fact]
        public void TestCase6()
        {
            List<Student> _manyStudents = new List<Student>();
            for (var i = 1; i <= 501; i++)
            {
                _manyStudents.Add(new Student($"ST{i:0000}"));
            }
            Assert.Throws<System.ArgumentException>(() => _studentScore.SetStudentScore("ST0100", 99, _manyStudents));
        }

        [Fact]
        public void TestCase7()
        {
            Assert.Throws<System.ArgumentException>(() => _studentScore.SetStudentScore("4094W020", -1, _students));
        }

        [Theory, InlineData("4094W020", 0, true)]
        public void TestCase8(string id, int score, bool expectValue)
        {
            bool result = _studentScore.SetStudentScore(id, score, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("4094W020", 1, true)]
        public void TestCase9(string id, int score, bool expectValue)
        {
            bool result = _studentScore.SetStudentScore(id, score, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("4094W020", 99, true)]
        public void TestCase10(string id, int score, bool expectValue)
        {
            bool result = _studentScore.SetStudentScore(id, score, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("4094W020", 100, true)]
        public void TestCase11(string id, int score, bool expectValue)
        {
            bool result = _studentScore.SetStudentScore(id, score, _students);
            Assert.Equal(result, expectValue);
        }

        [Fact]
        public void TestCase12()
        {
            Assert.Throws<System.ArgumentException>(() => _studentScore.SetStudentScore("4094W020", 101, _students));
        }

    }

}
