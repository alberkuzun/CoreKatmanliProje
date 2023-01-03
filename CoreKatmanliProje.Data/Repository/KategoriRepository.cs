using CoreKatmanliProje.Data.Repository.IRepository;
using CoreKatmanliProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreKatmanliProje.Data.Repository
{
    public class DepartmanlarRepository : Repository<Departmanlar>, IDepartmanlarRepository
    {
        private ApplicationDbContext _context;
        public DepartmanlarRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
