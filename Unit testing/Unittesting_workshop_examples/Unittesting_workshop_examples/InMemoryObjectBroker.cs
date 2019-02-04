using System;
using System.Collections.Generic;
using System.Linq;

namespace Unittesting_workshop_examples
{
    public interface IObjectBroker
    {
        IQueryable<T> AsQueryable<T>();
        T Add<T>(T objectToAdd);
    }

    public class InMemoryObjectBroker: IObjectBroker
    {
        private readonly Dictionary<Type, List<object>> _storage = new Dictionary<Type, List<object>>();

        public IQueryable<T> AsQueryable<T>()
        {
            return _storage[typeof(T)].Cast<T>().AsQueryable();
        }

        public T Add<T>(T objectToAdd)
        {
            if (_storage.ContainsKey(typeof(T)) == false)
            {
                var newList = new List<object> {objectToAdd};
                _storage.Add(typeof(T), newList);
            }
            else
            {
                _storage[typeof(T)].Add(objectToAdd);
            }

            return objectToAdd;
        }
    }

    
}