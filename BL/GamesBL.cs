using Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace BL
{
	internal class GamesBL : IGamesBL
	{
		private GamesDal _dal;

		public GamesBL(GamesDal dal)
		{
			_dal = dal;
		}

		public Game GetByUserId(int userId)
		{
			return _dal.GetByUserId(userId);
		}

		public void WriteGameToBD(Game play)
		{
			_dal.WriteGameToBD(play);
		}
	}
}
