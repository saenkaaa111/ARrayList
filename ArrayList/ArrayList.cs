using System;


namespace ArrayList
{
    public class ArrayList
    {
   
        private int[] _array;
        public int RealLength { get; private set; }

        public ArrayList()
        {
            RealLength = 0;
            _array = new int[10];

        }
        public ArrayList(int a)
        {
            RealLength = 1;
            _array = new int[10];
            _array[0] = a;
        }
        public ArrayList(int[] array)
        {
           
            RealLength = array.Length;
            _array = array;
            if (RealLength<10)
            {
                int[] _tmp = new int[10];
                for (int i = 0; i < _array.Length; i++)
                {
                    _tmp[i] = _array[i];
                }
                _array = _tmp;
            }
            
        }
        public int[] ToArray()
        {
            int[] result = new int[RealLength];
            for (int i = 0; i < RealLength; i++)
            {
                result[i] = _array[i];

            }
            return result;
        }
        public void AddToArray()
           
        {
            if (RealLength==0)
            {
                _array = new int[2];
            }
            else
            {
                int a = RealLength;
                int[] tmp1 = new int[RealLength * 3 / 2];
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
                _array = tmp1;
            }
            
                       
        }
        public void ConstrictionArray() 
        {
            int[] _tmp = new int[RealLength];
            for (int i = 0; i < _tmp.Length; i++)
            {
                _tmp[i] = _array[i];
            }
            _array = _tmp;
        }

        public void AddLast(int val)
        {

            if (RealLength >= _array.Length-1)
            {
                AddToArray();
            }
            _array[RealLength] = val;
            RealLength++;
            
        }
        public int GetLength()
        {
            return RealLength;
        }
        public void MoveElementsToRight(int idx, int n)
        {
            int a = RealLength;
            if (a+n >= _array.Length)
            {
                AddToArray();
            }
            for (int i = a + n-1; i > idx; i--)
            {
                _array[i] = _array[i-n];

            }
            for (int i = idx; i < idx+n; i++)
            {
                _array[i]=0;
            }
            RealLength += n;
        }
        public void MoveElementsToLeft(int idx, int n)
        {
            for (int i = idx-n+1; i < _array.Length - n; i++)
            {
                _array[i]= _array[i+n];
            }
            
            
            RealLength -= n;
        }

        public void AddFirst(int val)
        {
            if (RealLength >= _array.Length-1)
            {
                AddToArray();
            }
            MoveElementsToRight(0, 1);            
            _array[0] = val;
            
            
        }
        public void AddLast(ArrayList list)
        {
            int newLenght = RealLength + list.RealLength;
            int[] tmp = new int[newLenght];
            int[] lst = list.ToArray();
            for (int i = 0; i < RealLength; i++)
            {
                tmp[i] = _array[i];
            }
            int count = 0;
            for (int i = RealLength; i < newLenght; i++)
            {
                tmp[i] = lst[count];
                count++;
            }
            _array = tmp;
            RealLength = newLenght;
        }
        public void AddFirst(ArrayList list)
        {
            int newLenght = RealLength + list.RealLength;
            int[] tmp = new int[newLenght];
            int[] lst = list.ToArray();
            for (int i = 0; i < list.RealLength; i++)
            {
                tmp[i] = lst[i];
            }
            int count = 0;
            for (int i = list.RealLength; i < newLenght; i++)
            {
                tmp[i] = _array[count];
                count++;
            }
            _array = tmp;
            RealLength = newLenght;
        }


        public void RemoveFirst()
        {
            if (RealLength == 0)
            {
                throw new NullReferenceException("Нет элементов!");
            }
            MoveElementsToLeft(0, 1);
            
        }

        public void RemoveLast()
        {
            RealLength--;
        }

        public void AddAt(int idx, int val)
        {
            if (idx >= RealLength)
            {
                throw new NullReferenceException("Индекс находится за пределами");
            }
            else
            {
                if (RealLength >= _array.Length - 1)
                {
                    AddToArray();
                }
                MoveElementsToRight(idx, 1);
                _array[idx] = val;
                
            }
        }

        public void AddAt(int idx, ArrayList list)
        {
            if (idx > _array.Length)
            {
                throw new NullReferenceException("Индекс находится за пределами");
            }
            else if (RealLength == 0)
            {
                int[] lst = list.ToArray();
                _array = lst;
                RealLength++;
            }
            else
            {
                int newLenght = RealLength + list.RealLength;

                if (idx <= RealLength)
                {
                    int[] tmp = new int[newLenght];
                    int[] lst = list.ToArray();

                    int b = 0;
                    for (int i = 0; i < idx; i++)
                    {
                        tmp[i] = _array[i];
                        b++;
                    }
                    int count = 0;
                    for (int i = idx; i < list.GetLength() + idx; i++)
                    {
                        tmp[i] = lst[count];
                        count++;
                    }
                    for (int i = b + count; i < newLenght; i++)
                    {
                        tmp[i] = _array[b];
                        b++;
                    }
                    _array = tmp;
                    RealLength = newLenght;
                }
            }
        }

        public void RemoveAt(int idx)
        {
            if (idx >= RealLength)
            {
                throw new NullReferenceException("Индекс находится за пределами");
            }
            else
            {
                MoveElementsToLeft(idx, 1);
                
            }
            if (RealLength * 3 / 2 < _array.Length && RealLength > 10)
            {
                ConstrictionArray();
            }
        }

        public void RemoveFirstMultiple(int n)
        {
            if (n > RealLength)
            {
                throw new NullReferenceException("Нет такого количества элементов");
            }
            MoveElementsToLeft(n-1, n);
            if (RealLength * 3 / 2 < _array.Length && RealLength > 10)
            {
                ConstrictionArray();
            }

        }
        public void RemoveLastMultiple(int n)
        {
            if (n > RealLength)
            {
                throw new NullReferenceException("Нет такого количества элементов");
            }
            MoveElementsToLeft(RealLength, n);
            if (RealLength * 3 / 2 < _array.Length && RealLength > 10)
            {
                ConstrictionArray();
            }

        }
        public void RemoveAtMultiple(int idx, int n) 
        {
            if (n > RealLength)
            {
                throw new NullReferenceException("Индекс находится за пределами");
            }
            MoveElementsToLeft(idx+n-1, n);
            if (RealLength *3/2 < _array.Length && RealLength>10)
            {
                ConstrictionArray();
            }
            
            
        }
        public int RemoveFirst(int val)
        {
            int idx = IndexOf(val);
            if (idx==-1)
            {
                return -1;
            }
            RemoveAt(idx);
            if (RealLength * 3 / 2 < _array.Length && RealLength > 10)
            {
                ConstrictionArray();
            }
            return idx;
            
        }
        public int RemoveAll(int val)
        {
            int result = 0;
            for (int i = 0; i < RealLength; i++)
            {
                if (_array[i]==val)
                {
                    RemoveAt(i);
                    result++;
                }
            }
            if (RealLength * 3 / 2 < _array.Length && RealLength > 10)
            {
                ConstrictionArray();
            }
            return result;
        }

        public void Set(int idx, int val)
        {
            if (RealLength > idx)
            {
                _array[idx] = val;
            }
            else
            {
                throw new NullReferenceException("Индекс находится за пределами");
            }
        }
        
        public bool Contains(int val)
        {
            int a = IndexOf(val);
            if (a ==-1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int IndexOf(int val)
        {
            int result = -1;
            for (int i = 0; i < RealLength; i++)
            {
                if (_array[i] == val)
                {
                    result = i;
                    break;
                }
            }
            return result;
        }
        
        public int GetFirst()
        {
            int result = -1;
            if(RealLength ==0)
            {
                throw new NullReferenceException("Нет элементов");
            }
            if (RealLength > 0)
            {
                result = _array[0];
            }
            return result;
        }
        public int GetLast()
        {
            int result = -1;
            if(RealLength ==0)
            {
                throw new NullReferenceException("Нет элементов");
            }
            if (RealLength > 0)
            {
                result = _array[RealLength - 1];
            }
            return result;
        }
        public int Get(int idx)
        {
            int result;
            if (RealLength > idx)
            {
                result = _array[idx];
            }
            else
            {
                throw new NullReferenceException("Индекс находится за пределами");
            }
            return result;
        }
        
        public void Reverse()
        {
            for (int i = 0; i < (RealLength / 2); i++)
            {
                int variable = _array[i];
                _array[i] = _array[RealLength - 1 - i];
                _array[RealLength - 1 - i] = variable;
            }
        }
        public int Max()
        {
            int b = -1;
            if (RealLength > 0)
            {
                b = _array[0];
                for (int i = 1; i < RealLength; i++)
                {
                    if (b < _array[i])
                    {
                        b = _array[i];
                    }
                }

            }
            return b;
        }

        public int IndexOfMax()
        {
            int index = -1;
            if (RealLength > 0)
            {
                index = 0;
                int b = _array[0];
                for (int i = 1; i < RealLength; i++)
                {
                    if (b < _array[i])
                    {
                        b = _array[i];
                        index = i;
                    }
                }
                
            }
            return index;
        }
        public int Min()
        {
            int b = -1;
            if (RealLength > 0)
            {
                b = _array[0];
                for (int i = 1; i < RealLength; i++)
                {
                    if (b > _array[i])
                    {
                        b = _array[i];
                    }
                }

            }
            return b;
        }
        public int IndexOfMin()
        {
            int index = -1; 
            if (RealLength > 0)
            {
                index = 0;
                int b = _array[0];
                for (int i = 1; i < RealLength; i++)
                {
                    if (b > _array[i])
                    {
                        b = _array[i];
                        index = i;
                    }
                }
                
            }
            return index;

            
        }
        public void Sort()
        {
            int min;
            int variable;
            for (int i = 0; i < RealLength - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < RealLength; j++)
                {
                    if (_array[j] < _array[min])
                    {
                        min = j;
                    }
                }
                variable = _array[min];
                _array[min] = _array[i];
                _array[i] = variable;
            }
            
        }
        public void SortDesc()
        {
            int variable;
            for (int i = 0; i < RealLength; i++)
            {
                for (int j = 0; j < RealLength; j++)
                {
                    if (j == RealLength - 1)
                    {
                        continue;
                    }
                    while (_array[j] < _array[j + 1])
                    {
                        variable = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = variable;
                    }
                }
            }

        }

    }
}
