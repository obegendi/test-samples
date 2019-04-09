using Moq;
using Services.NumberGenerators;
using System.Linq;
using Xunit;

namespace Services.Tests.LuckyNumberServiceTest
{
    public partial class LuckyNumberServiceTest
    {
        [Fact]
        public void GenerateLotteryNumber_Returns_Five_Numbers()
        {
            // Arrange
            var moq = new Mock<INumberGenerator>(); 
            moq.Setup(x => x.GetRandom(It.IsAny<int>(), It.IsAny<int>())).Returns(13);
            var subject = new LuckyNumberService(moq.Object);

            // Act
            var result = subject.GenerateLotteryNumber();

            // Assert
            Assert.Equal(5, result.Count());
        }

         [Fact]
        public void GenerateLotteryNumber_Should_Not_CallRandom()
        {
            // Arrange
            var moq = new Mock<INumberGenerator>(); 
            moq.Setup(x => x.GetRandom(It.IsAny<int>(), It.IsAny<int>())).Returns(13);
            var subject = new LuckyNumberService(moq.Object);

            // Act
            var result = subject.GenerateLotteryNumber();

            // Assert
            moq.Verify(mock => mock.GetRandom(), Times.Once()); //Should Never!
        }

    }
}