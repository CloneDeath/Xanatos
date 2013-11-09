using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xanatos
{
	interface IGameState
	{
		void Initialize();
		void Uninitialize();
		void Draw2D(float dt);
		void Update(float dt);
	}
}
