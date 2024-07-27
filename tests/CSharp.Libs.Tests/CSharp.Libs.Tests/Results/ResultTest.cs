using CSharp.Libs.Results;
using Xunit;

namespace CSharp.Libs.Tests.Results
{
    public class ResultTests
    {
        [Fact]
        public void StatusWithSuccessTest()
        {
            var result = Result<string>.Success("Value");

            Assert.NotNull(result);
            Assert.NotEmpty(result.Data);
            Assert.True(result.IsSuccess);
        }

        [Fact]
        public void StatusWithErrorTest()
        {
            var result = Result<string>.Error("Error");

            Assert.NotNull(result);
            Assert.Null(result.Data);
            Assert.False(result.IsSuccess);
        }

        [Fact]
        public void StatusWithListErrorsTest()
        {
            var result = Result<string>.Error(new List<string> { "Error 1", "Error 2" });

            Assert.NotNull(result);
            Assert.Null(result.Data);
            Assert.False(result.IsSuccess);
        }

        [Fact]
        public void StatusWithInvalidTest()
        {
            var result = Result<string>.Invalid(new ValidationError("identifier", "error message"));

            Assert.NotNull(result);
            Assert.Null(result.Data);
            Assert.False(result.IsSuccess);
        }

        [Fact]
        public void StatusWithListInvalidsTest()
        {
            var result = Result<string>.Invalid(new List<ValidationError> { new("identifier", "error message") });

            Assert.NotNull(result);
            Assert.Null(result.Data);
            Assert.False(result.IsSuccess);
        }
    }
}
