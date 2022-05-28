using DataAccess.DbAccess;
using DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Data {
  public class UserData : IUserData {
    private readonly ISqlDataAccess _sqlDataAccess;

    public UserData(ISqlDataAccess sqlDataAccess) {
      _sqlDataAccess = sqlDataAccess;
    }

    public Task<IEnumerable<UserModel>> GetUsersAsync() {
      return _sqlDataAccess.LoadDataAsync<UserModel, dynamic>("dbo.spUser_GetAll", new { });
    }

    public async Task<UserModel?> GetUserAsync(int id) {
      var results = await _sqlDataAccess.LoadDataAsync<UserModel, dynamic>(
        "dbo.spUser_Get",
        new { Id = id });

      return results.FirstOrDefault();
    }

    public Task InsertUserAsync(UserModel user) {
      return _sqlDataAccess.SaveDataAsync("dbo.spUser_Insert", new { user.FirstName, user.LastName });
    }

    public Task UpdateUserAsync(UserModel user) {
      return _sqlDataAccess.SaveDataAsync("dbo.spUser_Update", user);
    }

    public Task DeleteUserAsync(int id) {
      return _sqlDataAccess.SaveDataAsync("dbo.spUser_Delete", new { Id = id });
    }
  }
}
