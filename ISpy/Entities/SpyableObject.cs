using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Nez;
namespace ISpy
{
	public class SpyableObject : Entity, IClickable
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
			position = new Vector2(0, 0);
			foreach (var rectangle in _data.Rectangles)
			{
				addComponent(new BoxCollider(rectangle));
			}
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
					SoundQueueProcessor.Add(soundEffect);
				}
			}

		}
	}
}
