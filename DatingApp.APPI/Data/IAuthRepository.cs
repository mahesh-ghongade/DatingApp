using System.Threading.Tasks;
using DatingApp.APPI.Models;

namespace DatingApp.APPI.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);

         Task<User> Login(string username, string password);
         
         Task<bool> UserExists(string username);
    }
}