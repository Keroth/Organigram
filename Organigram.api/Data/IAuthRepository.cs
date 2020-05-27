using System.Threading.Tasks;
using Organigram.api.Models;

namespace Organigram.api.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
    }
}