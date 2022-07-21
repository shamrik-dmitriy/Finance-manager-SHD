using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.SHD.Infrastructure.DataAccess.Repositories.Specific
{
    public abstract class BaseSpecificRepository
    {
        protected string _connectionString;

        public enum TypeOfExistenseCheck
        {
            DoesExistInDb,
            DoesNotExistInDb
        }

        public enum RequestType
        {
            Add,
            Update,
            Read,
            Delete,
            ConfirmAdd,
            ConfirmDelete
        }
    }
}
