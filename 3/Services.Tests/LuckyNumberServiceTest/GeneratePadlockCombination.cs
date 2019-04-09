using Moq;
using Services.NumberGenerators;
using System.Linq;
using Xunit;

namespace Services.Tests.LuckyNumberServiceTest
{
    public partial class LuckyNumberServiceTest
    {
        [Fact]
        public void GeneratePadlockCombination_Returns_Three_Numbers()
        {
            // Arrange
            var moq = new Mock<INumberGenerator>();
            moq.Setup(x => x.GetRandom(It.IsAny<int>(), It.IsAny<int>())).Returns(13);
            var subject = new LuckyNumberService(moq.Object);

            // Act
            var result = subject.GeneratePadlockCombination();

            // Assert
            Assert.Equal(3, result.Count());
        }
    }
}