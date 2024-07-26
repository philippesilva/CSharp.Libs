using CSharp.Libs.Enums;
using Xunit;

namespace CSharp.Libs.Tests.Enums
{
    public class EnumExtensionTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            var status = Status.Warning;

            var description = status.GetDescription();

            Assert.NotEmpty(description);
            Assert.Equal("Warning", description);
        }
    }
}