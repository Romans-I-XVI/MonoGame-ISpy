using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ISpy
{
	public struct SpyableObjectData
	{
		public List<Rectangle> Rectangles;
		public string Text;
		public string AudioFilePath;
		public SpyableObjectData(Rectangle rectangle, string text, string audio_file_path = null)
		{
			Rectangles = new List<Rectangle>() { rectangle };
			Text = text;
			AudioFilePath = audio_file_path;
		}

		public SpyableObjectData(List<Rectangle> rectangles, string text, string audio_file_path = null)
		{
			Rectangles = rectangles;
			Text = text;
			AudioFilePath = audio_file_path;
		}
	}
}
