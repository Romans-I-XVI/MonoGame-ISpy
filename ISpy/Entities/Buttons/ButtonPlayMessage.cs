using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;

namespace ISpy
{
	public class ButtonPlayMessage : Entity, IClickable
	{
		SpyableObjectControl _spyable_object_control;
		Texture2D ButtonTexture;
		public ButtonPlayMessage(SpyableObjectControl spyable_object_control, bool play_message_on_creation = false)
		{
			_spyable_object_control = spyable_object_control;
			if (play_message_on_creation)
				PlayMessage();
		}

		public override void onAddedToScene()
		{
			base.onAddedToScene();
			ButtonTexture = scene.content.Load<Texture2D>(Content.Sprites.ispy_message);
			addComponent(new Sprite(ButtonTexture));
			addComponent(new BoxCollider());
			position = new Vector2(GameRoot.MaxX - ButtonTexture.Width / 2, GameRoot.MaxY - ButtonTexture.Height / 2);
		}

		public void onClick()
		{
			PlayMessage();
		}

		public void PlayMessage()
		{
			if (!SoundQueueProcessor.isPlaying)
			{
				SoundQueueProcessor.Add(_spyable_object_control.ISpyIntroSound, 100);
				foreach (var spyable_object in _spyable_object_control.SpyableObjectList)
				{
					if (!spyable_object.Found)
					{
						SoundQueueProcessor.Add(spyable_object.soundEffect, 50);
					}
				}
			}
		}
	}
}
