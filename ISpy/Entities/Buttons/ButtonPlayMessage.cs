using System;
using Nez;

namespace ISpy
{
	public class ButtonPlayMessage : Entity, IClickable
	{
		SpyableObjectControl _spyable_object_control;
		public ButtonPlayMessage(SpyableObjectControl spyable_object_control, bool play_message_on_creation = false)
		{
			_spyable_object_control = spyable_object_control;
			if (play_message_on_creation)
				PlayMessage();
		}

		public void onClick()
		{
			PlayMessage();
		}

		public void PlayMessage()
		{
			if (!SoundQueueProcessor.isPlaying)
			{
				SoundQueueProcessor.Add(_spyable_object_control.ISpyIntroSound, 100);
				foreach (var spyable_object in _spyable_object_control.SpyableObjectList)
				{
					if (!spyable_object.Found)
					{
						SoundQueueProcessor.Add(spyable_object.soundEffect, 50);
					}
				}
			}
		}
	}
}
