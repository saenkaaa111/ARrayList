using NUnit.Framework;

namespace ArrayListTests
{
    public class Tests
    {
        private ArrayList _arrayList;

        [SetUp]
        public void Setup()
        {
            _arrayList = new ArrayListQ();
        }

        [Test]
        public void ToArrayTest()
        {
            //arrange
            int RealLenght = 5;
            int[] expected = new int[0];
            //act
            //int actual = _arrayList.ToArray();

            //assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AddToArrayTest()
        {
            //arrange
            int RealLenght = 5;
            int[] expected = new int[5] { 3, 4, 5, 6, 7 };
            //act
            int actual = _arrayList.AddTo();

            //assert
            Assert.AreEqual(expected, actual);

            int a = RealLenght;
            int[] tmp1 = new int[RealLenght * 3 / 2];
            for (int i = 0; i < tmp1.Length; i++)
            {
                if (i != a)
                {
                    tmp1[i] = _array[i];
                }
                else
                {
                    break;
                }
            }
            _array = new int[RealLenght * 3 / 2];
            for (int i = 0; i < _array.Length; i++)
            {
                if (i != a)
                {
                    _array[i] = tmp1[i];
                }
                else
                {
                    break;
                }
            }
            return _array;

        }




        
    }
}