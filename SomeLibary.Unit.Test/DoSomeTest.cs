using System;
using Xunit;

namespace SomeLibary.Unit.Test
{
    public class DoSomeTest
    {
        [Fact]
        public void SholuldRerurnName()
        {
            //given 
            string name = "Artur";
            string expectedName = "Pan Artur";
            var doStuff = new  AddName();

            //when 
          string actualName = doStuff.GetName(name);

            //then
            Assert.Equal(expectedName, actualName);
        }
    }
}
