using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Nez;

namespace ISpy
{
	public class SpyableObjectControl : Entity
	{
		public List<SpyableObject> SpyableObjectList { get; private set; }
		public SoundEffect ISpyIntroSound { get; private set; }
		public SoundEffect ISpyYouWin { get; private set; }
		private bool _found_all = false;
		public bool FoundAll
		{
			get { return _found_all; }
			private set
			{
				if (_found_all == false && value == true)
				{
					_found_all = true;
					SoundQueueProcessor.Add(ISpyYouWin);
				}
			}
		}
		public SpyableObjectControl(List<SpyableObject> spyable_object_list)
		{
			FoundAll = false;
			position = new Vector2(GameRoot.MinX, GameRoot.MaxY - 50);
			SpyableObjectList = spyable_object_list;
			
			//foreach (var spyable_object in SpyableObjectList)
			//{
			//	var text_drawer = addComponent(new Text(GameRoot.DefaultFont, "I spy with my little eye...", new Vector2(0, 0), Color.Red));
			//	text_drawer.setRenderLayer(-1);
			//}
		}

		public override void onAddedToScene()
		{
			base.onAddedToScene();
			ISpyIntroSound = scene.content.Load<SoundEffect>(Content.Sounds.iSpy);
			ISpyYouWin = scene.content.Load<SoundEffect>(Content.Sounds.youWin);
			scene.addEntity(new ButtonPlayMessage(this, true));
		}

		public override void update()
		{
			base.update();
			bool found_all = true;
			foreach (var item in SpyableObjectList)
			{
				if (!item.Found)
					found_all = false;
			}
			FoundAll = found_all;
		}
	}
}
