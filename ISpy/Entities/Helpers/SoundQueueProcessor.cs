using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;
using Nez;

namespace ISpy
{
	public class SoundQueueProcessor
	{
		private static readonly GameTimeSpan _timer = new GameTimeSpan();
		private static List<SoundQueueItem> _sound_list = new List<SoundQueueItem>();
		private static bool _is_sound_playing = false;
		public static bool isPlaying { get { return _is_sound_playing; } }

		public SoundQueueProcessor()
		{
		}

		public static void Add(SoundEffect sound_effect, int delay_after_playing = 0, Action exec_after_playing = null)
		{
			_sound_list.Add(new SoundQueueItem(sound_effect, delay_after_playing, exec_after_playing));
		}

		public static void Process()
		{
			process_first_sound:
			if (_sound_list.Count > 0)
			{
				if (!_is_sound_playing)
				{
					_sound_list[0].SoundEffect.Play();
					_is_sound_playing = true;
					_timer.Mark();
				}
				else
				{
					if (_timer.TotalMilliseconds > _sound_list[0].SoundEffect.Duration.TotalMilliseconds + _sound_list[0].DelayAfterPlaying)
					{
						_is_sound_playing = false;
						if (_sound_list[0].ExecAfterPlaying != null)
							_sound_list[0].ExecAfterPlaying();
						_sound_list.RemoveAt(0);
						goto process_first_sound;
					}
				}
			}
		}

		internal struct SoundQueueItem
		{
			internal SoundEffect SoundEffect;
			internal int DelayAfterPlaying;
			internal Action ExecAfterPlaying;
			internal SoundQueueItem(SoundEffect sound_effect, int delay_after_playing, Action exec_after_playing)
			{
				SoundEffect = sound_effect;
				DelayAfterPlaying = delay_after_playing;
				ExecAfterPlaying = exec_after_playing;
			}
		}
	}
}
