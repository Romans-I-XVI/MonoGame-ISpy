using System;
using Microsoft.Xna.Framework;
using Nez;
namespace ISpy
{
	public class SpyableObject : Entity
	{
		
		public SpyableObject(Rectangle rectangle)
		{
			position = new Vector2(rectangle.Center.X, rectangle.Center.Y);
			addComponent(new BoxCollider(rectangle.Width, rectangle.Height));
		}
	}
}
