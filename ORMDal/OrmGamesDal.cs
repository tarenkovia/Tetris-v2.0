using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using Entities;
using DAL;


namespace ORMDal
{
	public class OrmGamesDal : IGamesDal
	{
		//public Game GetByUserId(int userId)
		//{
		//	var context = new DefaultDbContext();
		//	try
		//	{
		//		var play = context.Games.FirstOrDefault(item => item.UserId == userId);

		//		if (play == null)
		//		{
		//			return null;
		//		}
		//		var entity = new Game()
		//		{
		//			Id = play.Id,
		//			UserId = userId,
		//			Score = play.Score
		//		};
		//		return entity;
		//	}
		//	finally
		//	{
		//		context.Dispose();
		//	}
		//}

		public List<Game> GetByUserId(int UserId)
		{
			var context = new DefaultDbContext();
			try
			{
				var game = context.Games.Where(item => item.UserId == UserId);
				if (game == null)
				{
					return null;
				}
				List<Game> res = new List<Game>();
				foreach (Games item in game)
				{
					res.Add(new Game()
					{
						Id = item.Id,
						Score = item.Score,
						UserId = item.UserId
					});
				}
				return res;
			}
			finally
			{
				context.Dispose();
			}
		}

		public void WriteGameToBD(Game play)
		{
			var context = new DefaultDbContext();
			try
			{
				context.Games.Add(new Games()
				{
					UserId = play.UserId,
					Score = play.Score
				});
				context.SaveChanges();
			}
			finally
			{
				context.Dispose();
			}
		}
	}
}
