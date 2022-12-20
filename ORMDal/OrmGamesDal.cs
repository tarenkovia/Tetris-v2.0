using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interfaces;
using Entities;
using DAL;


namespace ORMDal
{
	internal class OrmGamesDal : GamesDal
	{
		public Game GetByUserId(int userId)
		{
			var context = new DefaultDbContext();
			try
			{
				var play = context.Games.FirstOrDefault(item => item.UserId == userId);

				if (play == null)
				{
					return null;
				}
				var entity = new Game()
				{
					Id = play.Id,
					UserId = userId,
					Score = play.Score
				};
				return entity;
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
