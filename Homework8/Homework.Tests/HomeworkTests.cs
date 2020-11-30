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

        [Theory, InlineData("4094W020", 99.0f, false)]
        public void TestCase1(string id, float score, bool expectValue)
        {
            List<Student> _noStudents = new List<Student>();
            bool result = _studentScore.SetStudentScore(id, score, _noStudents);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("4094W020", 99.0f, true)]
        public void TestCase2(string id, float score, bool expectValue)
        {
            bool result = _studentScore.SetStudentScore(id, score, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("ST0100", 99.0f, true)]
        public void TestCase3(string id, float score, bool expectValue)
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
        public void TestCase4()
        {
            List<Student> _manyStudents = new List<Student>();
            for (var i = 1; i <= 501; i++)
            {
                _manyStudents.Add(new Student($"ST{i:0000}"));
            }
            Assert.Throws<System.ArgumentException>(() => _studentScore.SetStudentScore("ST0100", 99.0f, _manyStudents));
        }

        [Fact]
        public void TestCase5()
        {
            Assert.Throws<System.ArgumentException>(() => _studentScore.SetStudentScore("4094W020", -0.1f, _students));
        }

        [Theory, InlineData("4094W020", 0.0f, true)]
        public void TestCase6(string id, float score, bool expectValue)
        {
            bool result = _studentScore.SetStudentScore(id, score, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("4094W020", 0.1f, true)]
        public void TestCase7(string id, float score, bool expectValue)
        {
            bool result = _studentScore.SetStudentScore(id, score, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("4094W020", 99.9f, true)]
        public void TestCase8(string id, float score, bool expectValue)
        {
            bool result = _studentScore.SetStudentScore(id, score, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("4094W020", 100.0f, true)]
        public void TestCase9(string id, float score, bool expectValue)
        {
            bool result = _studentScore.SetStudentScore(id, score, _students);
            Assert.Equal(result, expectValue);
        }

        [Fact]
        public void TestCase10()
        {
            Assert.Throws<System.ArgumentException>(() => _studentScore.SetStudentScore("4094W020", 100.1f, _students));
        }

    }

}
