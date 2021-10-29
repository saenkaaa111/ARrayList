using ArrayList;
using NUnit.Framework;

namespace ArrayList.Tests
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[5] { 2, 3, 4, 5, 6 }, new int[6] { 2, 3, 2, 4, 5, 6 }, 2, 2)]
        [TestCase(new int[0] { }, new int[0] { }, 3, 4)]
        [TestCase(new int[3] { 2, 3, 4 }, new int[4] { 2, 3, 2, 4 }, 2, 2)]
        public void AddAtTest(int[] array, int[] expected, int idx, int val)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.AddAt(2, 2);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        [TestCase(new int[5] { 2, 3, 4, 5, 6 }, new int[3] { 9, 8, 7 }, new int[8]{2,3,9,8,7,4,5,6}, 2)]
        [TestCase(new int[3] { 9, 8, 7 }, new int[5] { 2, 3, 4, 5, 6 },  new int[8]{2,3,4,5,6, 9, 8,7 }, 0)]
        [TestCase(new int[0] { }, new int[1] {2},  new int[1]{2}, 0)]
        public void AddAtListTest(int[] array, int[] list, int[] expected, int val)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            ArrayList1111 arrayLis = new ArrayList1111(list);
            arrayList.AddAt(val, arrayLis);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }


        


        [TestCase(new int[5] { 2, 3, 4, 5, 6 })]
        [TestCase(new int[0] { })]
        [TestCase(new int[1] { 2})]
        public void ToArrayTest(int[] expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(expected);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        


        [TestCase(new int[11] { 2, 3, 4, 5, 6, 5, 6, 9, 8, 4,6 }, new int[11] { 2, 3, 4, 5, 6, 5, 6, 9, 8, 4,6})]
        
        public void AddToArrayTest(int[]array, int[] expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.AddToArray();
            Assert.AreEqual(arrayList.ToArray(), expected);
        }


        [TestCase(new int[10] { 2, 3, 4, 5, 6, 5, 6, 9, 8, 4 }, new int[11] { 2, 3, 4, 5, 6, 5, 6, 9, 8, 4, 8 }, 8)]
        [TestCase(new int[5] { 0,0,2,6,8 }, new int[6] { 0, 0, 2, 6, 8, 7 }, 7)]
        [TestCase(new int[0] { }, new int[1] {3 }, 3)]
        public void AddLastTest(int[] array, int[] expected, int val)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.AddLast(val);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        [TestCase(new int[10] { 2, 3, 4, 5, 6, 5, 6, 9, 8, 4 }, 10)]
        [TestCase(new int[5] { 0,0,2,6,8 }, 5)]
        [TestCase(new int[0] { }, 0)]
        public void GetLengthTest(int[] array, int expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            int actual = arrayList.GetLength();
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[10] { 2, 3, 4, 5, 6, 5, 6, 9, 8, 4 }, new int[11] { 8, 2, 3, 4, 5, 6, 5, 6, 9, 8, 4}, 8)]
        [TestCase(new int[5] { 0, 0, 2, 6, 8 }, new int[6] { 7, 0, 0, 2, 6, 8 }, 7)]
        [TestCase(new int[0] { }, new int[1] { 3 }, 3)]
        public void AddFirstValTest(int[] array, int[] expected, int val)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.AddFirst(val);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        [TestCase(new int[3] { 2, 3, 4}, new int[2] { 7, 6 }, new int[5] { 2, 3, 4, 7, 6 } )]
        [TestCase(new int[0] {}, new int[2] { 7, 6 }, new int[2] { 7, 6 } )]
        [TestCase(new int[1] {3}, new int[2] { 7, 6 }, new int[3] { 3, 7, 6 } )]
        
        public void AddLastListTest(int[] array, int[] list, int[] expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            ArrayList1111 arrayLis = new ArrayList1111(list);
            arrayList.AddLast(arrayLis);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        [TestCase(new int[3] { 2, 3, 4}, new int[2] { 7, 6 }, new int[5] { 7, 6, 2, 3, 4 } )]
        [TestCase(new int[0] {}, new int[2] { 7, 6 }, new int[2] { 7, 6 } )]
        [TestCase(new int[1] {3}, new int[2] { 7, 6 }, new int[3] { 7, 6,3 } )]
        
        public void AddFirstListTest(int[] array, int[] list, int[] expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            ArrayList1111 arrayLis = new ArrayList1111(list);
            arrayList.AddFirst(arrayLis);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        

        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, new int[4] { 5, 2, 6, 8 })]
        [TestCase(new int[0] { }, new int[0] { })]
        [TestCase(new int[1] { 1}, new int[0] { })]
        public void RemoveFirstTest(int[] array, int[] expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.RemoveFirst();
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, new int[4] { 6, 5, 6, 8 },  2)]
        [TestCase(new int[0] { }, new int[0] { }, 0)]
        [TestCase(new int[1] { 1}, new int[0] { }, 0)]
        public void RemoveAtTest(int[] array, int[] expected, int idx)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.RemoveAt(idx);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, new int[4] { 6, 5, 2, 6} )]
        [TestCase(new int[1] { 1}, new int[0] { })]
        public void RemoveLastTest(int[] array, int[] expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.RemoveLast();
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, new int[3] { 2, 6, 8}, 2 )]
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, new int[0] { }, 5 )]
        [TestCase(new int[1] { 1}, new int[0] { }, 1)]
        public void RemoveFirstMultipleTest(int[] array, int[] expected, int val)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.RemoveFirstMultiple(val);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, new int[3] { 6,5,2}, 2 )]
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, new int[0] { }, 5 )]
        [TestCase(new int[1] { 1}, new int[0] { }, 1)]
        public void RemoveLastMultipleTest(int[] array, int[] expected, int val)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.RemoveLastMultiple(val);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, new int[3] { 6,5,8}, 2,2 )]
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, new int[0] { }, 0,5 )]
        [TestCase(new int[1] { 1}, new int[0] { }, 0,1)]
        public void RemoveAtMultipleTest(int[] array, int[] expected, int idx, int val)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.RemoveAtMultiple(idx,val);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, 8, 4 )]
        [TestCase(new int[5] { 5, 6, 2, 6, 8 },  6, 1 )]
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, 4, -1 )]
        [TestCase(new int[1] { 1}, 1, 0)]
        public void RemoveFirstValTest(int[] array, int val, int expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            int actual= arrayList.RemoveFirst(val);
            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, 6, 2 )]
        [TestCase(new int[5] { 5, 6, 2, 6, 8 },  2, 1 )]
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, 4, 0 )]
        [TestCase(new int[1] { 1}, 1, 1)]
        public void RemoveAllTest(int[] array, int val, int expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            int actual= arrayList.RemoveAll(val);
            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, 2, 1000, new int[5] { 6, 5, 1000, 6, 8 })]
        [TestCase(new int[0] { }, 0, 1000, new int[0] { })]
        [TestCase(new int[1] { 6}, 5, 1000, new int[1] {6 })]
        
        public void SetTest(int[] array, int idx, int val, int[] expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.Set(idx, val);
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, 2, true)]
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, 99, false)]
        [TestCase(new int[0] { }, 1000, false)]
        
        public void ContainsTest(int[] array, int val, bool expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            bool actual = arrayList.Contains(val);
            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, 5, 1)]
        [TestCase(new int[5] { 6, 5, 2, 2, 8 }, 2, 2)]
        [TestCase(new int[3] {1,2,3 }, 1000, -1)]
        [TestCase(new int[0] {}, 1000, -1)]
        
        public void IndexOfTest(int[] array, int val, int expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            int actual = arrayList.IndexOf(val);
            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, 6)]
        [TestCase(new int[5] { 222, 5, 2, 2, 8 }, 222)]
        [TestCase(new int[3] {1,2,3 }, 1)]
        [TestCase(new int[0] {}, -1)]
        
        public void GetFirstTest(int[] array, int expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            int actual = arrayList.GetFirst();
            Assert.AreEqual(actual, expected);
        }


        [TestCase(new int[5] { 6, 5, 2, 6, 8 }, 8)]
        [TestCase(new int[5] { 222, 5, 2, 2, 1000 }, 1000)]
        [TestCase(new int[3] {1,2,3 }, 3)]
        [TestCase(new int[0] {}, -1)]
        
        public void GetLastTest(int[] array, int expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            int actual = arrayList.GetLast();
            Assert.AreEqual(actual, expected);
        }
        
        
        [TestCase(new int[5] { 6, 5, 2, 77, 8 }, 3, 77)]
        [TestCase(new int[5] { 222, 5, 2, 2, 1000 }, 0, 222)]
        [TestCase(new int[3] {1,2,3 }, 5, -1)]
        [TestCase(new int[3] {1,2,3 }, 2, 3)]
        [TestCase(new int[0] {}, 0, -1 )]
        
        public void GetTest(int[] array, int idx, int expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            int actual = arrayList.Get(idx);
            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 77, 8 },new int[5] { 8,77,2,5,6 })]
        [TestCase(new int[2] { 222, 1 },new int[2] { 1, 222 })]
        [TestCase(new int[1] {1}, new int[1] {1})]
        [TestCase(new int[0] {},new int[0] { })]
        
        public void ReverseTest(int[] array,  int[] expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.Reverse();
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        
        [TestCase(new int[5] { 6, 5, 2, 77, 8 }, 77)]
        [TestCase(new int[2] { 222, 1 },222)]
        [TestCase(new int[1] {1}, 1)]
        [TestCase(new int[0] {}, -1)]
        
        public void MaxTest(int[] array,  int expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            int actual = arrayList.Max();
            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 77, 8 }, 2)]
        [TestCase(new int[2] { 222, 1 },1)]
        [TestCase(new int[1] {1}, 1)]
        [TestCase(new int[0] {}, -1)]
        
        public void MinTest(int[] array,  int expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            int actual = arrayList.Min();
            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 1, 8 }, 3)]
        [TestCase(new int[2] { 1, 15 },0)]
        [TestCase(new int[1] {1}, 0)]
        [TestCase(new int[0] {}, -1)]
        
        public void IndexOfMinTest(int[] array,  int expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            int actual = arrayList.IndexOfMin();
            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 1, 8 }, 4)]
        [TestCase(new int[2] { 1, 15 },1)]
        [TestCase(new int[1] {1}, 0)]
        [TestCase(new int[0] {}, -1)]
        
        public void IndexOfMaxTest(int[] array,  int expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            int actual = arrayList.IndexOfMax();
            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 1, 8 },new int[5] { 1,2,5,6,8})]
        [TestCase(new int[2] { 1, 15 },new int[2] { 1, 15})]
        [TestCase(new int[1] {1},new int[1] {1})]
        [TestCase(new int[0] {},new int[0] {})]
        
        public void SortTest(int[] array,  int[] expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.Sort();
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
        
        [TestCase(new int[5] { 6, 5, 2, 1, 8 },new int[5] { 8,6,5,2,1})]
        [TestCase(new int[3] { 1, 15,3 }, new int[3] { 15,3,1})]
        [TestCase(new int[1] {1},new int[1] {1})]
        [TestCase(new int[0] {},new int[0] {})]
        
        public void SortDescTest(int[] array,  int[] expected)
        {
            ArrayList1111 arrayList = new ArrayList1111(array);
            arrayList.SortDesc();
            Assert.AreEqual(arrayList.ToArray(), expected);
        }
    }
}