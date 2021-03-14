using System;
using System.Collections;

namespace Module3_Task1.Helpers
{
    public class CustomList<T>
    {
        private T[] _list = new T[4];
        private int _size = 0;

        public void Add(T item)
        {
            if (_size + 1 > _list.Length)
            {
                ExpandArr();
            }

            _list[_size] = item;
            _size++;
        }

        public bool Remove(T item)
        {
            for (var i = 0; i < _size; i++)
            {
                Console.WriteLine(_list[i]);
                Console.WriteLine(item);

                /*if (_list[i] == item)
                {
                    _list[i] = default(T);
                }*/
            }

            return true;
        }

        public void RemoveAt(int index)
        {
            CheckIndex(index);
            _list[index] = default(T);
        }

        public void Sort()
        {
            CheckLength();
            Array.Sort(_list);
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _size; i++)
            {
                yield return _list[i];
            }
        }

        private void ExpandArr()
        {
            var newArr = new T[_list.Length * 2];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = _list[i];
            }

            _list = newArr;
        }

        private void CheckIndex(int index)
        {
            if (index > _size - 1 || index < 0)
            {
                throw new ArgumentOutOfRangeException($"Please, provide valid index. The current size of the array is {_size}.");
            }
        }

        private void CheckLength()
        {
            if (_size <= 0)
            {
                throw new Exception($"Array is empty.");
            }
        }
    }
}
