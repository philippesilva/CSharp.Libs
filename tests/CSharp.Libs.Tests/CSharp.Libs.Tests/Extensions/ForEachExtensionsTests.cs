using CSharp.Libs.Extensions;
using Xunit;

namespace CSharp.Libs.Tests.Extensions
{
    public class ForEachExtensionsTests
    {
        private readonly IEnumerable<int> _items = [1, 2, 3];

        [Fact]
        public void ForEach()
        {
            var count = 0;

            _items.ForEach(x =>
            {
                count += x + 1;
            });

            Assert.Equal(9, count);
        }
    }
}
