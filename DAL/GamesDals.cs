using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Entities;
using System.Linq;

namespace DAL
{
	internal class GamesDals : IGamesDal
	{
		private List<Game> game = new List<Game>()
		{
			//new Game() {UserId = 0, Score = 0, Id = 0},
		};

		//public Game GetByUserId(int userId)
		//{
		//	return game.FirstOrDefault(x => x.UserId == userId);
		//}
		public List<Game> GetByUserId(int UserId)
		{
			return (List<Game>)game.Where(item => item.UserId == UserId);
		}

		public Game GetById(int id)
		{
			return game.FirstOrDefault(x => x.Id == id);
		}

		public void WriteGameToBD(Game play)
		{
			game.Add(play);
		}
	}
}
