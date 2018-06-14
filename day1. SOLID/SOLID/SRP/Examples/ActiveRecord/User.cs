using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Examples.ActiveRecord
{
  // Active Record pattern
  // An object that wraps a row in a database table or view, encapsulates the database access, and adds domain logic on that data.
  public class User
  {
    public User(List<User> usersDb)
    {
      if (usersDb != null)
      {
        _fakeUsersDb = usersDb;
      }
      else
      {
        throw new ArgumentNullException("usersDb");
      }
    }

    private List<User> _fakeUsersDb;
    public string Name { get; set; }

    public Guid Id { get; set; }

    public void AddNew(string name,Guid id)
    {
      this.Name = name;
      this.Id = id;
    }

    public void Save()
    {
      _fakeUsersDb.Add(this);
    }

    public User FindUserById(Guid id)
    {
      var user = _fakeUsersDb.Find(x => x.Id == id);
      return user;
    }
  }

  // solution: create a repository class(UserRepository.cs)for work with database
  //public class User
  //{
  //  public User(string name, Guid Id)
  //  {
  //    this.Name = name;
  //    this.Id = Id;
  //  }
  //  public string Name { get; set; }
  //  public Guid Id { get; set; }
  //}

  //public class UserRepository
  //{
  //  private List<User> _fakeUsersDb = new List<User>();
  //  private User _temporaryUser = null;

  //  public void AddNew(User user)
  //  {
  //    _temporaryUser = user;
  //  }

  //  public void Save()
  //  {
  //    if (_temporaryUser != null)
  //    {
  //      _fakeUsersDb.Add(_temporaryUser);
  //    }
  //    else
  //    {
  //      throw new InvalidOperationException("Add new user before save!");
  //    }
  //  }

  //  public User FindUserById(Guid id)
  //  {
  //    var user = _fakeUsersDb.Find(x => x.Id == id);
  //    return user;
  //  }
  //}

}
