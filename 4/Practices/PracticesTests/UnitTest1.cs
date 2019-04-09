using AutoFixture;
using FluentAssertions;
using Practices;
using Practices.Models;
using Xunit;

namespace PracticesTests
{
    public class CustomerDALShould
    {
        [Fact]
        public void Add_Return_False_With_Empty()
        {
            //Arrange
            var dal = new CustomerDAL();
            var customer = new Customer();

            //Act
            var sut = dal.Add(customer);

            //Assert
            sut.Should().BeFalse();
        }

        [Fact]
        public void Add_With_Valid_Params()
        {
            //Arrange
            var dal = new CustomerDAL();
            var fixture = new Fixture();
            var customer = fixture.Create<Customer>();

            //Act       
            var sut = dal.Add(customer);

            //Assert
            sut.Should().BeTrue();

        }

        //[Fact]
        //public void Add_With_Valid_Phone()
        //{
        //    //Assert
        //    Fixture fixture = new Fixture();
        //    fixture.Customizations.Add(new PhoneBuilder());            
        //    var customer = fixture.Build<Customer>().Create();
        //    var dal = new CustomerDAL();
            
        //    //Act
        //    var sut = dal.Add(customer);

        //    sut.Should().BeTrue();
        //}

    }
}
