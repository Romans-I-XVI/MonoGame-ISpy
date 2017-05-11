using System;
using Microsoft.Xna.Framework;
using Nez;
namespace ISpy
{
	public class SpyableObject : Entity
	{
		public SpyableObject(int x, int y, int width, int height)
		{
			position = new Vector2(x, y);
			addComponent(new BoxCollider(width, height));
		}
	}
}
