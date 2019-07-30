using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM_POC_1.Data.Entities;
using COM_POC_1.Models;
using Microsoft.EntityFrameworkCore;

namespace COM_POC_1.Data.Repositories
{
    public class CoMRepository : ICoMRepository
    {
        private readonly CoMdbContext _context;

        public CoMRepository(CoMdbContext context)
        {
            _context = context;
        }

        public IEnumerable<Game> GetAllGames()
        {
            return _context.Games
                .OrderBy(g => g.Mc)
                .ToList();
        }

        public IEnumerable<Mc> GetAllMcs()
        {
            return _context.Mcs
                .OrderBy(mc => mc.Name)
                .ToList();
        }

        public IEnumerable<Player> GetPlayersByGame(int gameId)
        {
            var game = _context.Games.FirstOrDefault(g => g.GameId == gameId);
            return game.Players;

        }

        public bool SaveAll()
        {
           return _context.SaveChanges() > 0;
        }
    }
}
