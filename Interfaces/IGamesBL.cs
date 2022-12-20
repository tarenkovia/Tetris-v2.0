using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
	public interface IGamesBL
	{
		Game GetByUserId(int userID);
		void WriteGameToBD(Game game);
	}
}
