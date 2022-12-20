using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;
using Entities;
using System.Linq;

namespace DAL
{
	internal class GamesDals : GamesDal
	{
		private List<Game> game = new List<Game>();

		public Game GetByUserId(int userId)
		{
			return game.FirstOrDefault(x => x.UserId == userId);
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
