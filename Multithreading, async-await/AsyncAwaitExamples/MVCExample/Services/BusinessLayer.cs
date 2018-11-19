using System;
using System.Threading;
using System.Threading.Tasks;

namespace MVCExample.Services
{
    public class DomainModel
    {
        public string DomainField { get; set; }
    }

    public class BusinessLayer
    {
        public class BLL
        {
            private readonly DAL _dal;

            public BLL()
            {
                _dal = new DAL();
            }

            public DomainModel Do()
            {
                var dbModel = _dal.GetDbModel();

                return new DomainModel
                {
                    DomainField = dbModel.DbField
                };
            }
        }

        private class DAL
        {
            public async Task<DbModel> GetDbModelAsync()
            {
                //Call to db
                await Task.Delay(TimeSpan.FromSeconds(5));

                return new DbModel
                {
                    DbField = "Hello world"
                };
            }

            public DbModel GetDbModel()
            {
                //Call to db
                Thread.Sleep(TimeSpan.FromSeconds(5));

                return new DbModel
                {
                    DbField = "Hello world"
                };
            }
        }

        private class DbModel
        {
            public string DbField { get; set; }
        }
    }
}