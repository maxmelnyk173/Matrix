using NUnit.Framework;

namespace Matrix.Test
{
    [TestFixture]
    public class MatrixTest
    {
        [Test]
        public void MatchMatrix()
        {
            Matrix testMatrix = new Matrix(3,3); 
            int expectedSum = 15;
            int[,] testActual = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
           
            Assert.AreEqual(expectedSum, testMatrix.SumOfDiagonalElements(testActual));
        }
    }
}
