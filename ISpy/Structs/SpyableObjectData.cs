using System;
using Microsoft.Xna.Framework;

namespace ISpy
{
	public struct SpyableObjectData
	{
		public Rectangle Rectangle;
		public string Text;
		public string AudioFilePath;
		public SpyableObjectData(Rectangle rectangle, string text, string audio_file_path = null)
		{
			Rectangle = rectangle;
			Text = text;
			AudioFilePath = audio_file_path;
		}
	}
}
