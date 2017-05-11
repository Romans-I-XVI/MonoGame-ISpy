using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;

namespace ISpy
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class GameRoot : Core
	{
		public GameRoot() : base(isFullScreen: true)
		{
			Input.touch.enableTouchSupport();
			this.IsMouseVisible = false;
		}

		protected override void Initialize()
		{
			base.Initialize();
			var scene_play = new ScenePlay();
			Core.scene = scene_play;
		}

	}
}

