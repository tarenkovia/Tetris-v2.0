using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Interfaces
{
	public interface IGamesDal
	{
		//Game GetByUserId(int userID);
		List<Game> GetByUserId(int UserId);
		void WriteGameToBD(Game game);
	}
}
