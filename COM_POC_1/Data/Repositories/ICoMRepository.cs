using System.Collections.Generic;
using COM_POC_1.Data.Entities;
using COM_POC_1.Models;

namespace COM_POC_1.Data.Repositories
{
    public interface ICoMRepository
    {
        IEnumerable<Game> GetAllGames();
        IEnumerable<Mc> GetAllMcs();
        IEnumerable<Player> GetPlayersByGame(int gameId);
        bool SaveAll();
    }
}