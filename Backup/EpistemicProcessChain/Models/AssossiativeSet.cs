using System;
using System.Collections.Generic;
using System.Linq;

namespace EpistemicProcessChain.Models
{
    public class AssossiativeSet<T>
    {
        private T[] _array;
        private int _head;
        private Dictionary<T,int> _hash;
        private readonly int _capacity;
        private readonly Random _random = new Random();

        public AssossiativeSet(int capacity)
        {
            _array = new T[capacity];
            _head = 0;
            _hash = new Dictionary<T, int>();

            _capacity = capacity;
        }

        public AssossiativeSet(IEnumerable<T> values)
        {
            _array = new T[values.Count()];
            _head = 0;
            _hash = new Dictionary<T, int>();

            _capacity = values.Count();

            foreach (var value in values)
            {
                Add(value);
            }
        }

        public bool Add(T obj)
        {
            if (!Contains(obj))
            {
                _hash.Add(obj, _head);
                _array[_head] = obj;
                _head++;

                return true;
            }
            return false;
        }

        public void Remove(T obj)
        {
            var i = _hash[obj];
            
            _head--;
            _array[i] = _array[_head];
            _array[_head] = default(T);

            _hash.Remove(obj);
            _hash[_array[i]] = i;
        }

        public void Remove(int index)
        {
            T obj = this[index];
            if (index>=0 && index < _head && Contains(obj))
            {
                Remove(obj);
            }
            
        }

        public int FindIndexOf(T obj)
        {
            return _hash[obj];
        }

        public bool Contains(T obj)
        {
            return _hash.Keys.Contains(obj);
        }

        public void Clear()
        {
            _array = new T[_capacity];
            _head = 0;
            _hash = new Dictionary<T, int>();
        }

        public T GetRandomElement()
        {
            var r = _random.Next(Count); 
            return _array[r];
        }

        public T[] ToArray()
        {
            return _hash.Keys.ToArray();
        }

        public T this[int i]
        {
            get { return _array[i]; }
            set { _array[i] = value; }
        }

        public T Last()
        {
            return _array[_head - 1];
        }

        public T First()
        {
            return _array[0];
        }

        public int Count
        {
            get
            {
                return _head;
            }
        }

        public bool IsEmpty
        {
            get { return _head == 0; }
        }

        public AssossiativeSet<T> IntersectWith(AssossiativeSet<T> other)
        {
            AssossiativeSet<T> toret = new AssossiativeSet<T>(_capacity);
            if (other != null)
            {
                toret = Copy();
                foreach (T member in _array)
                {
                    if (!other.Contains(member))
                    {
                        toret.Remove(member);
                    }
                }
            }
            return toret;
        }

        public void Union(AssossiativeSet<T> other)
        {
            foreach (T member in other._array)
            {
                if (!Contains(member))
                {
                    Add(member);
                }
            }
        }

        public AssossiativeSet<T> Copy()
        {
            AssossiativeSet<T> toret = new AssossiativeSet<T>(this._capacity);
            _array.CopyTo(toret._array,0);
            foreach (var i in _hash)
            {
                toret._hash.Add(i.Key,i.Value);
            }
            toret._head = _head;
            return toret;
        }
    }
}
