using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
{
    private static readonly List<Game> games = new()
  {
    new Game()
    {
      Id = 1,
      Name = "Doom",
      Genre = "FPS",
      Price = 59.99m,
      ReleaseDate = new DateTime(2016, 5, 13)
    },
    new Game()
    {
      Id = 2,
      Name = "Doom Eternal",
      Genre = "FPS",
      Price = 59.99m,
      ReleaseDate = new DateTime(2020, 3, 20)
    },
    new Game()
    {
      Id = 3,
      Name = "Doom 3",
      Genre = "FPS",
      Price = 9.99m,
      ReleaseDate = new DateTime(2004, 8, 3)
    },
  };

  public static Game[] GetGames() => games.ToArray();

  public static void AddGame(Game game) => games.Add(game);
}