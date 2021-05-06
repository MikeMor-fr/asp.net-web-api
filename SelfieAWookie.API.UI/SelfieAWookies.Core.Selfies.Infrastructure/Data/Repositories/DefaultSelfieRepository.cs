using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;
using SelfieAWookies.Core.Selfies.Domain;
using SelfiesAWookies.Core.Framework;

namespace SelfieAWookies.Core.Selfies.Infrastructure.Data.Repositories
{
    public class DefaultSelfieRepository : ISelfieRepository
    {
        private readonly SelfiesContext _context;
        
        public DefaultSelfieRepository(SelfiesContext context)
        {
            _context = context;
        }
        
        public ICollection<Selfie> GetAll()
        {
            return _context.Selfies.Include(item => item.Wookie).ToList();
        }

        public IUnitOfWork UnitOfWork => _context;
    }
}