using System;
using System.Collections.Generic;
using Xunit;

using Homework;

namespace Homework.Tests
{
    public class EquivalencePartitionTest
    {
        private readonly StudentName _studentName;
        private readonly List<Student> _students;

        public EquivalencePartitionTest()
        {
            _studentName = new StudentName();
            _students = new List<Student>
                {
                    new Student("4094W020"),
                    new Student("4094W021"),
                };
        }

        [Theory, InlineData("4094W020", "eric", true)]
        public void TestCase1(string id, string name, bool expectValue)
        {
            bool result = _studentName.SetName(id, name, _students);
            Assert.Equal(result, expectValue);
        }

        [Fact]
        public void TestCase2()
        {
            Assert.Throws<System.FormatException>(() => _studentName.SetName("4094W020", "Eric", _students));
        }

        [Theory, InlineData("4094W020", "eric123", true)]
        public void TestCase3(string id, string name, bool expectValue)
        {
            bool result = _studentName.SetName(id, name, _students);
            Assert.Equal(result, expectValue);
        }

        [Fact]
        public void TestCase4()
        {
            Assert.Throws<System.FormatException>(() => _studentName.SetName("4094W020", "eric$", _students));
        }


        [Theory, InlineData("4094W020", "amyLin168", true)]
        public void TestCase5(string id, string name, bool expectValue)
        {
            bool result = _studentName.SetName(id, name, _students);
            Assert.Equal(result, expectValue);
        }

        [Fact]
        public void TestCase6()
        {
            Assert.Throws<System.FormatException>(() => _studentName.SetName("4094W020", "", _students));
        }

        [Fact]
        public void TestCase7()
        {
            Assert.Throws<System.FormatException>(() => _studentName.SetName("4094W020", "an", _students));
        }

        [Fact]
        public void TestCase8()
        {
            Assert.Throws<System.FormatException>(() => _studentName.SetName("4094W020", "imNumber1SuperHero", _students));
        }

    }

}
