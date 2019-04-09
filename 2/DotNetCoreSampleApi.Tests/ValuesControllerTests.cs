using System.Linq;
using DotNetCoreSampleApi.Controllers;
using Xunit;

namespace DotNetCoreSampleApi.Tests
{
    public class ValuesControllerTest
    {
        [Fact]
        public void Get_ShouldReturn_Value1AndValue2()
        {
            var controller = new ValuesController();

            var values = controller.Get().ToList();

            Assert.True(values.Contains("value1"), "value1 is not returned");
            Assert.True(values.Contains("value2"), "value2 is not returned");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(int.MaxValue)]
        public void GetWithId_ShouldReturn_Value(int id)
        {
            var controller = new ValuesController();

            var value = controller.Get(id);

            Assert.True(value == "value");            
        }
    }
}