using CSharp.Libs.Extensions;
using Xunit;

namespace CSharp.Libs.Tests.Extensions
{
    public class WhereIfExtensionsTests
    {
        private readonly IEnumerable<int> _items = [1, 2, 3, 2, 4];

        [Fact]
        public void WhereIf()
        {
            var items = _items.WhereIf(_items.Any(), x => x.Equals(2));

            Assert.Equal( 2, items.Count());
        }
    }
}
