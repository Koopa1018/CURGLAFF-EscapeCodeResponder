
namespace Clouds.UI.TextWriting {
	public static class BuiltinEscapeCodes {
		/// <summary>
		/// This character marks the next as an escape code.
		/// </summary>
		public const char escapeChar = '\\';
		/// <summary>
		/// \d[*.***] - Pause typing for however long is indicated.
		/// </summary>
		public const char delay = 'd';
		/// <summary>
		/// \s[*.***] - Set the delay between typed characters to the number indicated.
		/// </summary>
		public const char typeSpeed = 's';
		/// <summary>
		/// \i[***] - Display an icon from the icon set.
		/// </summary>
		public const char icon = 'i';
		/// <summary>
		/// \! - When the next message is shown, show it in addition to this one.
		/// </summary>
		public const char dontClear = '!';
		/// <summary>
		/// \< - Set the box to write all at once. Used to toggle, but for TMPro compatibility it's constant now.
		/// </summary>
		public const char writeAllAtOnce = '<';
		/// <summary>
		/// \> - Set the box to write in the normal style: if default is one at a time, then one at a time, and vice versa.
		/// </summary>
		public const char writeAtDefaultPace = '>';
	}
}