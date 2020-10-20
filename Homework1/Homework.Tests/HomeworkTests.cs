using System;
using Xunit;

using Homework;

namespace Homework.Tests
{
    public class StudentFindTest
    {
        private readonly StudentFind _studentFind;

        public StudentFindTest()
        {
            _studentFind = new StudentFind();
        }

        [Theory,
        InlineData("Nick", "4094W007"),
        InlineData("Aven", "4094W010"),
        InlineData("Totti", "4094W011"),
        InlineData("Jeff", "4094W012"),
        InlineData("Terry", "4094W008"),
        ]
        public void NameShouldBeFound(string name, string expectValue)
        {
            var result = _studentFind.Find(name);
            Assert.Equal(result, expectValue);
        }

        [Theory, InlineData("John", ""), InlineData("Jack", "")]
        public void NameShouldNotBeFound(string name, string expectValue)
        {
            var result = _studentFind.Find(name);
            Assert.Equal(result, expectValue);
        }
    }
}