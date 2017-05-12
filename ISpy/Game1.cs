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
		public const int WIDTH = 1280;
		public const int HEIGHT = 720;
		public const int HORIZONTALBLEED = WIDTH - (int)(WIDTH * 0.8f);
		public const int VERTICALBLEED = HEIGHT - (int)(HEIGHT * 0.8f);
		public static int MinX { get { return HORIZONTALBLEED / 2; } }
		public static int MinY { get { return VERTICALBLEED / 2; } }
		public static int MaxX { get { return WIDTH - MinX; } }
		public static int MaxY { get { return HEIGHT - MinY; } }

		public GameRoot() : base(WIDTH, HEIGHT, true, windowTitle: "ISpy")
		{
			Scene.setDefaultDesignResolution(WIDTH, HEIGHT, Scene.SceneResolutionPolicy.BestFit, HORIZONTALBLEED, VERTICALBLEED);
			this.IsMouseVisible = false;
		}

		protected override void Initialize()
		{
			base.Initialize();
			Input.touch.enableTouchSupport();
			new ScenePlay(Levels.LivingRoom);
		}

	}
}

