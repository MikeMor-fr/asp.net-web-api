using System.Collections;
using System.Collections.Generic;

namespace SelfieAWookies.Core.Selfies.Domain
{
    public interface ISelfieRepository
    {
        ICollection<Selfie> GetAll();
    }
}