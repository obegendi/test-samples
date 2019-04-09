using AutoFixture.Kernel;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace PracticesTests
{
    public class PhoneBuilder : ISpecimenBuilder
    {
        public object Create(object request, ISpecimenContext context)
        {
            var propertyInfo = request as PropertyInfo;

            if (propertyInfo != null)
            {
                if (propertyInfo.Name == "Phone" && propertyInfo.PropertyType == typeof(string))
                {
                    return "555123432";                    
                }
            }
            return new NoSpecimen();
        }
    }
}
