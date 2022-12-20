using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Interfaces
{
	public interface GamesDal
	{
		Game GetByUserId(int userID);
		void WriteGameToBD(Game game);
	}
}
