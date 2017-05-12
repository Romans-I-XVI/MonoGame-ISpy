using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.BitmapFonts;

namespace ISpy
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class GameRoot : Core
	{
		public const int WIDTH = 1280;
		public const int HEIGHT = 720;
		public const int HORIZONTALBLEED = 320;
		public const int VERTICALBLEED = 0;
		public static int MinX { get { return HORIZONTALBLEED / 2; } }
		public static int MinY { get { return VERTICALBLEED / 2; } }
		public static int MaxX { get { return WIDTH - MinX; } }
		public static int MaxY { get { return HEIGHT - MinY; } }
		public static BitmapFont DefaultFont;

		public GameRoot() : base(WIDTH, HEIGHT, true, windowTitle: "ISpy")
		{
			Scene.setDefaultDesignResolution(WIDTH, HEIGHT, Scene.SceneResolutionPolicy.BestFit, HORIZONTALBLEED, VERTICALBLEED);
			this.IsMouseVisible = false;
		}

		protected override void Initialize()
		{
			base.Initialize();
			DefaultFont = Content.Load<BitmapFont>(Nez.Content.Fonts.ariel);
			Input.touch.enableTouchSupport();
			new ScenePlay(Levels.Kitchen);
		}

	}
}

