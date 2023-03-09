using Core.Loyal.Models.FTMUSIC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Loyal.Interfaces.Providers
{
    public interface IUserProvider
    {
        Task<List<UserModel>> GetList();
        Task<long> SaveUser(UserModel user);
    }
}
