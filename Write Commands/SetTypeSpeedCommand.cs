namespace Clouds.UI.TextWriting
{
	/// <summary>
	/// Command that changes the time characters take to be typed into the box.
	/// </summary>
	public struct SetTypeSpeedCommand : IMessageCommand {
		/// <summary>
		/// How long should each character take to be added? (0 = default type speed)
		/// </summary>
		public float timePerCharacter;
	}
}