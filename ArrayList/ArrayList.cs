using System;


namespace ArrayList
{
    public class ArrayList1111
    {
   
        private int[] _array;
        public int RealLenght { get; private set; }

        public ArrayList1111()
        {
            RealLenght = 0;
            _array = new int[10];

        }
        public ArrayList1111(int lenght)
        {
            RealLenght = 0;
            _array = new int[lenght];
        }
        public ArrayList1111(int[] array)
        {
            RealLenght = array.Length;
            _array = array; 
        }
        public int[] ToArray()
        {
            int[] result = new int[RealLenght];
            for (int i = 0; i < RealLenght; i++)
            {
                result[i] = _array[i];

            }
            return result;
        }
        public void AddToArray()
           
        {
            if (RealLenght==0)
            {
                _array = new int[2];
            }
            else
            {
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
            }
            
                       
        }
        
        public void AddLast(int val)
        {

            if (RealLenght >= _array.Length-1)
            {
                AddToArray();
            }
            _array[RealLenght] = val;
            RealLenght++;
            
        }
        public int GetLength()
        {
            return RealLenght;
        }
        public void AddFirst(int val)
        {
            if (RealLenght >= _array.Length-1)
            {
                AddToArray();
            }
            int a = RealLenght;
            for (int i = 0; i < a+1; i++)
            {
                _array[a+1-i] = _array[a-i];
            }
            _array[0] = val;
            RealLenght++;
            
        }
        public void AddLast(ArrayList1111 list)
        {
            int newLenght = RealLenght + list.RealLenght;
            int[] tmp = new int[newLenght];
            int[] lst = list.ToArray();
            for (int i = 0; i < RealLenght; i++)
            {
                tmp[i] = _array[i];
            }
            int count = 0;
            for (int i = RealLenght; i < newLenght; i++)
            {
                tmp[i] = lst[count];
                count++;
            }
            _array = tmp;
            RealLenght = newLenght;
        }
        public void AddFirst(ArrayList1111 list)
        {
            int newLenght = RealLenght + list.RealLenght;
            int[] tmp = new int[newLenght];
            int[] lst = list.ToArray();
            for (int i = 0; i < list.RealLenght; i++)
            {
                tmp[i] = lst[i];
            }
            int count = 0;
            for (int i = list.RealLenght; i < newLenght; i++)
            {
                tmp[i] = _array[count];
                count++;
            }
            _array = tmp;
            RealLenght = newLenght;
        }


        public void RemoveFirst()
        {
            if (RealLenght>0)
            {
                int a = RealLenght;
                if (RealLenght > 0)
                {
                    for (int i = 0; i < a - 1; i++)
                    {
                        _array[i] = _array[i + 1];
                    }
                    RealLenght--;
                    _array[a - 1] = 0;
                }
            }
            
            
        }
        public void RemoveLast()
        {
            _array[RealLenght-1] = 0;
            RealLenght--;
            
        }
        public void AddAt(int idx, int val)
        {
            if (idx >= _array.Length)
            {
                Console.WriteLine("Sorry");
                
            }
            else
            {
                if (RealLenght >= _array.Length-1)
                {
                    AddToArray();
                }

                int a = RealLenght;
                int count = 0;
                if (a >= idx)
                {
                    for (int i = idx; i < a + 1; i++)
                    {
                        _array[a - count] = _array[a-1 - count];
                        count++;
                    }
                    _array[idx] = val;
                    RealLenght++;
                }
            }
        }
        
        public void AddAt(int idx, ArrayList1111 list)
        {
            if (idx > _array.Length)
            {
            }
            else if (RealLenght==0)
            {
                int[] lst = list.ToArray();
                _array = lst;
                RealLenght++;
            }
            else
            {
                int newLenght = RealLenght + list.RealLenght;
                
                if (idx <= RealLenght)
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
                    RealLenght = newLenght;
                }
            }
            
        }


        
        public void RemoveAt(int idx)
        {
            if (idx >= _array.Length)
            {
                
            }
            else
            {
                int a = RealLenght;
                if (a > idx)
                {
                    for (int i = idx; i < a - 1; i++)
                    {
                        _array[i] = _array[i + 1];
                    }
                    _array[a - 1] = 0;
                    RealLenght--;
                }
            }
        }
        
        public void RemoveFirstMultiple(int n)
        {
            int a = RealLenght;
            if (a>=n)
            {
                for (int i = 0; i < a-n; i++)
                {
                    _array[i] = _array[n+i];
                    
                }
                for (int i = a - n; i < a; i++)
                {
                    _array[i] = 0;
                }
                RealLenght -= n;
            }
        }
        public void RemoveLastMultiple(int n)
        {
            int a = RealLenght;
            if (a>=n)
            {
                for (int i = a-n; i < a; i++)
                {
                    _array[i] = 0;
                    RealLenght--;
                }
            }
        }
        public void RemoveAtMultiple(int idx, int n) 
        {
            int a = RealLenght;
            if (a > idx)
            {
                for (int i = idx; i < idx + n; i++)
                {
                    if (i + n > a)
                    {
                        _array[i] = 0;
                        //RealLenght--;

                    }
                    else
                    {
                        if (i + n<a)
                        {
                            _array[i] = _array[i + n];
                            //RealLenght--;
                        }
                        
                    }
                }
                for (int i = idx+n-1; i < _array.Length; i++)
                {
                    _array[i] = 0;
                }
                RealLenght -= n;
            }
        }
        public int RemoveFirst(int val)
        {
            int result = -1;
            for (int i = 0; i < RealLenght; i++)
            {
                if (_array[i]==val)
                {
                    RemoveAt(i);
                    result = i;
                    break;
                }
            }
            return result;
            
        }
        public int RemoveAll(int val)
        {
            int result = 0;
            for (int i = 0; i < RealLenght; i++)
            {
                if (_array[i]==val)
                {
                    RemoveAt(i);
                    result++;
                }
            }
            return result;
        }

        public void Set(int idx, int val)
        {
            if (RealLenght > idx)
            {
                _array[idx] = val;
            }
        }
        
        public bool Contains(int val)
        {
            bool result = false;
            for (int i = 0; i < RealLenght; i++)
            {
                if (_array[i] == val)
                {
                    result = true;
                    return result;
                }
            }
            return result;
        }
        public int IndexOf(int val)
        {
            int result = -1;
            for (int i = 0; i < RealLenght; i++)
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
            if (RealLenght > 0)
            {
                result = _array[0];
            }
            return result;
        }
        public int GetLast()
        {
            int result = -1;
            if (RealLenght > 0)
            {
                result = _array[RealLenght - 1];
            }
            return result;
        }
        public int Get(int idx)
        {
            int result = -1;
            if (RealLenght > idx)
            {
                result = _array[idx];
            }
            return result;
        }
        
        public void Reverse()
        {
            for (int i = 0; i < (RealLenght / 2); i++)
            {
                int variable = _array[i];
                _array[i] = _array[RealLenght - 1 - i];
                _array[RealLenght - 1 - i] = variable;
            }
        }
        public int Max()
        {
            int b = -1;
            if (RealLenght>0)
            {
                b = _array[0];
                for (int i = 1; i <= RealLenght; i++)
                {
                    if (i == RealLenght)
                    {
                        break;
                    }
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
            if (RealLenght > 0)
            {
                index = 0;
                int b = _array[0];
                for (int i = 1; i <= RealLenght; i++)
                {
                    if (i == RealLenght)
                    {
                        break;
                    }
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
            if (RealLenght > 0)
            {
                b = _array[0];
                for (int i = 1; i <= RealLenght; i++)
                {
                    if (i == RealLenght)
                    {
                        break;
                    }
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
            if (RealLenght > 0)
            {
                index = 0;
                int b = _array[0];
                for (int i = 1; i <= RealLenght; i++)
                {
                    if (i == RealLenght)
                    {
                        break;
                    }
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
            for (int i = 0; i < RealLenght - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < RealLenght; j++)
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
            for (int i = 0; i < RealLenght; i++)
            {
                for (int j = 0; j < RealLenght; j++)
                {
                    if (j == RealLenght - 1)
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
