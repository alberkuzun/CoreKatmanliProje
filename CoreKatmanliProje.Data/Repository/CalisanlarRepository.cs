using CoreKatmanliProje.Data.Repository.IRepository;
using CoreKatmanliProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreKatmanliProje.Data.Repository
{
        public class CalisanlarRepository : Repository<Calisanlar>, ICalisanlarRepository
        {
            private ApplicationDbContext _context;
            public CalisanlarRepository(ApplicationDbContext context) : base(context)
            {
                _context = context;
            }
        }
    
}
