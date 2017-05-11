using System;
using Nez;
namespace ISpy
{
	public class Player : Entity
	{
		public Player()
		{
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
				}
			}
		}
	}
}
