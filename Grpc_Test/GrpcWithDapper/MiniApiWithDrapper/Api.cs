namespace MiniApiWithDrapper;

public static class Api {
  public static void ConfigureApi(this WebApplication app) {
    app.MapGet("/Users", GetUsersAsync);
    app.MapGet("/Users/{id}", GetUserAsync);
    app.MapPost("/Users", InsertUserAsync);
    app.MapPut("/Users", UpdateUserAsync);
    app.MapDelete("/Users", DeleteUserAsync);
  }

  private static async Task<IResult> GetUsersAsync(IUserData data) {
    try {
      return Results.Ok(await data.GetUsersAsync());
    }
    catch (Exception ex) {
      return Results.Problem(ex.Message);
    }
  }

  private static async Task<IResult> GetUserAsync(int id, IUserData data) {
    try {
      var results = await data.GetUserAsync(id);
      if (results == null) {
        return Results.NotFound();
      }

      return Results.Ok(results);
    }
    catch (Exception ex) {
      return Results.Problem(ex.Message);
    }
  }

  private static async Task<IResult> InsertUserAsync(UserModel user, IUserData data) {
    try {
      await data.InsertUserAsync(user);
      return Results.Ok();
    }
    catch (Exception ex) {
      return Results.Problem(ex.Message);
    }
  }

  private static async Task<IResult> UpdateUserAsync(UserModel user, IUserData data) {
    try {
      await data.UpdateUserAsync(user);
      return Results.Ok();
    }
    catch (Exception ex) {
      return Results.Problem(ex.Message);
    }
  }

  private static async Task<IResult> DeleteUserAsync(int id, IUserData data) {
    try {
      await data.DeleteUserAsync(id);
      return Results.Ok();
    }
    catch (Exception ex) {
      return Results.Problem(ex.Message);
    }
  }
}
