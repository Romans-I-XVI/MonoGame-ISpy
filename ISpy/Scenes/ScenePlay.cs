using System;
using Nez;
namespace ISpy
{
	public class ScenePlay : Scene
	{
		public ScenePlay()
		{
            addRenderer(new DefaultRenderer());
			addEntity(new Player());
		}
	}
}
