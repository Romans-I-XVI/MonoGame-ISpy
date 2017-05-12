using System;
using Nez;
namespace ISpy
{
	public class Player : Entity
	{
		public Player()
		{
			addComponent(new CircleCollider(1));
		}

		public override void update()
		{
			base.update();
			ProcessTouch();
		}

		private void ProcessTouch()
		{
			var touches = Input.touch.currentTouches;
			foreach (var touch in touches)
			{
				var previousLocation = new Microsoft.Xna.Framework.Input.Touch.TouchLocation();
				if (!touch.TryGetPreviousLocation(out previousLocation))
				{
					position = touch.scaledPosition();
					Android.Util.Log.Info("Player", "ID: " + touch.Id.ToString() + "Position: " + position.X.ToString() + " , " + position.Y.ToString());
					ProcessCollision();
				}
			}
		}

		private void ProcessCollision()
		{
			var collider = getComponent<Collider>();
			CollisionResult collisionResult = new CollisionResult();
			if (collider.collidesWithAny(out collisionResult))
			{
				var other_entity = collisionResult.collider.entity;
				if (other_entity is SpyableObject)
				{
					((SpyableObject)other_entity).onClick();
				}

				Android.Util.Log.Info("Player.ProcessCollision", collisionResult.collider.entity.GetType().ToString());
				if (true)
				{

				}
			}

		}
	}
}
