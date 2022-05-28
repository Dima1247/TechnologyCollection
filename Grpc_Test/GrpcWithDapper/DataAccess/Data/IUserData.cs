using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data {
  public interface IUserData {
    Task DeleteUserAsync(int id);
    Task<IEnumerable<UserModel>> GetUsersAsync();
    Task<UserModel?> GetUserAsync(int id);
    Task InsertUserAsync(UserModel user);
    Task UpdateUserAsync(UserModel user);
  }
}