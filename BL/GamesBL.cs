using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace BL
{
	public class GamesBL : IGamesBL
	{
		private IGamesDal _dal;

		public GamesBL(IGamesDal dal)
		{
			_dal = dal;
		}

		//public Game GetByUserId(int userId)
		//{
		//	return _dal.GetByUserId(userId);
		//}
		public List<Game> GetByUserId(int UserId)
		{
			return _dal.GetByUserId(UserId);
		}

		public void WriteGameToBD(Game play)
		{
			_dal.WriteGameToBD(play);
		}
	}
}
