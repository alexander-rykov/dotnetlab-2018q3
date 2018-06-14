using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3LSP
{
  //eсли для каждого объекта o1 типа S существует объект o2 типа T, 
  //который для всех программ P определен в терминах T, 
  //то поведение P не изменится, если o2 заменить на o1 при условии, что S является подтипом T.

  //Функции, которые используют ссылки на базовые классы, 
  //должны иметь возможность использовать объекты производных классов, не зная об этом.
  public class DoubleList<T> : IList<T>
  {
    private readonly IList<T> innerList = new List<T>();

    public void Add(T item)
    {
      innerList.Add(item);
      innerList.Add(item);
    }

    public void Clear()
    {
      throw new NotImplementedException();
    }

    public bool Contains(T item)
    {
      throw new NotImplementedException();
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
      throw new NotImplementedException();
    }

    public bool Remove(T item)
    {
      throw new NotImplementedException();
    }

    public int Count { get; }
    public bool IsReadOnly { get; }

    public IEnumerator<T> GetEnumerator()
    {
      throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    public int IndexOf(T item)
    {
      throw new NotImplementedException();
    }

    public void Insert(int index, T item)
    {
      throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
      throw new NotImplementedException();
    }

    public T this[int index]
    {
      get { throw new NotImplementedException(); }
      set { throw new NotImplementedException(); }
    }
  }

  //add example with exceptions. Child class throws exception that doesn't catches by the client. the client except the other exception.

  //public class BaseClass
  //{
  //  public void Method(int value)
  //  {
  //    if (value == 10)
  //    {
  //      throw new ApplicationException("App Exception!");
  //    }
  //  }
  //}

  //public class NewClass : BaseClass
  //{
  //  public void Method(int value)
  //  {
  //    if (value == 10)
  //    {
  //      throw new AggregateException("App Exception!");
  //    }
  //  }
  //}
}
