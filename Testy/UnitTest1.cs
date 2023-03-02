
using Biblioteka;

namespace Testy
{
    public class UnitTest1
    {
        RownanieKwadratowe kw = new RownanieKwadratowe(1, 2, -3);
        [Fact]
        public void Test1()
        {
            Assert.Equal(new double[] { 1, -3 }, kw.Wynik());
        }
    }
}