using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;

namespace ISpy
{
	public class ISpyPicture : Entity
	{
		public string ImagePath { get; private set; }
		public Texture2D Image { get; private set; }

		public ISpyPicture(string image_path)
		{
			position = new Vector2(GameRoot.WIDTH / 2, GameRoot.HEIGHT / 2);
			ImagePath = image_path;
			Image = null;
		}

		public override void onAddedToScene()
		{
			base.onAddedToScene();
			Image = scene.content.Load<Texture2D>(ImagePath);
			var image = addComponent(new Sprite(Image));
			image.setRenderLayer(0);
		}
	}
}
