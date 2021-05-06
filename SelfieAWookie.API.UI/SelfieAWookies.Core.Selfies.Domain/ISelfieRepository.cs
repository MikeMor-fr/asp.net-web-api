using System.Collections;
using System.Collections.Generic;
using SelfiesAWookies.Core.Framework;

namespace SelfieAWookies.Core.Selfies.Domain
{
    public interface ISelfieRepository : IRepository
    {
        ICollection<Selfie> GetAll();
    }
}