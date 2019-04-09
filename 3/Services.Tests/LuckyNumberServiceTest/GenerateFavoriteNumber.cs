using System;
using Services.NumberGenerators;
using Xunit;
using Moq;

namespace Services.Tests.LuckyNumberServiceTest
{
    public partial class LuckyNumberServiceTest
    {
        Mock<INumberGenerator> _moq = null;
        public LuckyNumberServiceTest()
        {
            _moq = new Mock<INumberGenerator>();
        }
        [Fact]
        public void GenerateFavoriteNumber_Returns_Generated_Number()
        {
            // Arrange
            _moq.Setup(x => x.GetRandom(It.IsAny<int>(), It.IsAny<int>())).Returns(13);
            var subject = new LuckyNumberService(_moq.Object);

            // Act
            var result = subject.GenerateFavoriteNumber();

            // Assert
            Assert.Equal(13, result);
        }

        [Fact]
        public void GenerateFavoriteNumber_Throws_ArgumentException_When_Min_Is_Greater_Then_Max()
        {
            // Arrange
            _moq.Setup(x => x.GetRandom()).Returns(13);
            var subject = new LuckyNumberService(_moq.Object);

            // Act
            void Action()
            {
                subject.GenerateFavoriteNumber(10, 1);
            }

            // Assert
            Assert.Throws<ArgumentException>(() => Action());
        }

        [Fact]
        public void GenerateFavoriteNumber_Throws_ArgumentOutOfRangeException_When_Max_Is_Greater_Then_100()
        {
            // Arrange
            _moq.Setup(x => x.GetRandom()).Returns(13);
            var subject = new LuckyNumberService(_moq.Object);

            // Act
            void Action()
            {
                subject.GenerateFavoriteNumber(1, 101);
            }

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Action());
        }

        [Fact]
        public void GenerateFavoriteNumber_Throws_ArgumentOutOfRangeException_When_Min_Is_Less_Then_1()
        {
            // Arrange
            _moq.Setup(x => x.GetRandom()).Returns(13);
            var subject = new LuckyNumberService(_moq.Object);

            // Act
            void Action()
            {
                subject.GenerateFavoriteNumber(-1);
            }

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Action());
        }
    }
}