using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UserManagementClient.Models;

namespace UserManagementClient.Data
{
    public interface IUserService
    {
        Task<IList<User>> GetAllUsersAsync();
    }
}