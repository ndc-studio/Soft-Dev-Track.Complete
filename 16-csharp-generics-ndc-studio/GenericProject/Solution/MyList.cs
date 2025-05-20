using System.Collections.Generic;

namespace GenericSpace
{
    public class MyList<T>
    {
        private List<T> _entityList { get; set; }

        public MyList()
        {
            _entityList = [];
        }

        public void Add(T _entity)
        {
            _entityList.Add(_entity);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= _entityList.Count)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return _entityList[index];
        }
    }
}