using System;
using System.Collections.Generic;
using Xunit;

using Homework;

namespace Homework.Tests
{
    public class MutationTest
    {
        private readonly GoodStudentFind _goodStudentFind;
        private readonly GoodStudentFindMuted _goodStudentFindMuted;
        private readonly List<Student> _students;

        public MutationTest()
        {
            _goodStudentFind = new GoodStudentFind();
            _goodStudentFindMuted = new GoodStudentFindMuted();
            _students = new List<Student>
                {
                    // name, score, bmi
                    new Student("Nick", 95.0f, 22.0f),
                    new Student("Jack", 79.0f, 18.0f),
                    new Student("John", 80.0f, 26.0f),
                    new Student("Mary", 77.0f, 25.0f),
                };
        }

        //  Mutation testing coverage
        [Theory, InlineData("John", "YES")]
        public void TestCase1(string name, string expectValue)
        {
            var result = _goodStudentFind.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", "NO")]
        public void TestCase2(string name, string expectValue)
        {
            var result = _goodStudentFindMuted.IsGoodStudent(name, _students);
            Assert.Equal(result, expectValue);
        }
    }
}
