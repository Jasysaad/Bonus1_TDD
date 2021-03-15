using System;
using Xunit;

namespace Bonus1_TDD
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var grade = new LetterGrade();

            //Act
            var result = grade.letterGrade(98);

            //Assert 
            string letter = "A";
            Assert.Equal(letter, result);


        }
    }
}
