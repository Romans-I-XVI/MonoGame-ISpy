﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Nez;
namespace ISpy
{
	public class SpyableObject : Entity
	{
		private SpyableObjectData _data;
		public string Text { get { return _data.Text; } }
		public bool Found { get; private set; }
		public SoundEffect soundEffect { get; private set; }

		public SpyableObject(SpyableObjectData data)
		{
			_data = data;
			Found = false;
			soundEffect = null;
			position = new Vector2(_data.Rectangle.Center.X, _data.Rectangle.Center.Y);
			addComponent(new BoxCollider(_data.Rectangle.Width, _data.Rectangle.Height));
		}

		public override void onAddedToScene()
		{
			base.onAddedToScene();
			if (_data.AudioFilePath != null)
				soundEffect = scene.content.Load<SoundEffect>(_data.AudioFilePath);
		}

		public void onClick()
		{
			if (!Found)
			{
				Found = true;
				if (soundEffect != null)
				{
					soundEffect.Play();
				}
			}

		}
	}
}
