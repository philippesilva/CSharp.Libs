using CSharp.Libs.Enums;
using Xunit;

namespace CSharp.Libs.Tests.Enums
{
    public class EnummTests
    {
        [Fact]
        public void GetDescriptionTest()
        {
            var descriptions = Enumm.GetDescriptions<Status>();

            Assert.NotEmpty(descriptions);
        }

        [Fact]
        public void GetValueFromDescriptionTest()
        {
            var status = Enumm.GetValueFromDescription<Status>("Success");

            Assert.Equal(Status.Success.GetHashCode(), status.GetHashCode());
        }

        [Fact]
        public void ToDictionaryTest()
        {
            var dictionary = Enumm.ToDictionary<Status>();

            Assert.NotNull(dictionary);
        }
    }
}