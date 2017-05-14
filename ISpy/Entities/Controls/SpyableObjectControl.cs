﻿using System;
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
		public SpyableObjectControl(List<SpyableObject> spyable_object_list)
		{
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
			scene.addEntity(new ButtonPlayMessage(this, true));
		}
	}
}
