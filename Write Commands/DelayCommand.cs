using Unity.Mathematics;

namespace Clouds.UI.TextWriting
{
	/// <summary>
	/// Command that pauses text writing for an arbitrary length of time.
	/// </summary>
	public struct DelayCommand : IMessageCommand, IPauseOutputFlow {
		float _time;
		/// <summary>
		/// How long will writing wait?
		/// </summary>
		public float Time {
			get => _time;
			set => math.max(0, _time);
		}

		/// <summary>
		/// DelayCommand can pause outputting for an arbitrary length of time. (0 = one character's pause)
		/// </summary>
		public float outputBreakTime => _time;

		/// <summary>
		/// Constructs a DelayCommand told to wait a specific number of seconds.
		/// </summary>
		/// <param name="time">The amount of time to delay for, in seconds. (0 = use character-type time)</param>
		public DelayCommand(float time = 0) {
			_time = math.max(0,time);
		}
	}
}