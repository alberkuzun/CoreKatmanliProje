using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreKatmanliProje.Data.Repository.IRepository
{
    public interface IUnitofWork : IDisposable
    {

        ICalisanlarRepository Calisanlar { get; }

        IDepartmanlarRepository Departmanlar { get; }

        void Save();
    }
}
