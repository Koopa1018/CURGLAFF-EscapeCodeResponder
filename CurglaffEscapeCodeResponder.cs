using UnityEngine;
using Clouds.UI.TextWriting;

namespace Clouds.Impl.UI.TextWriter {
	[CreateAssetMenu(menuName = "One Instance Only/Dialogue/CURGLAFF Escape Code Responder")]
	public class CurglaffEscapeCodeResponder : EscapeCodeResponder {
		[SerializeField] char escapeInvoker = '>';
		[SerializeField] char macroInvoker 	= '%';

		public override char invokeFunctionCharacter {get => escapeInvoker;}
		public override char invokeMacroCharacter {get => macroInvoker;}
		public override bool customHandleEscapeInvokers {get => false;}

		public override (IMessageCommand, int) EvaluateEscapeCode (
			in string message,
			int currentPosition,
			out WriteCommand nextWrite
		) {
			(IMessageCommand cmdOut, int skipDist) returner;

			int startPos = currentPosition;

			//Eval the actual control-code set.
			switch (message[currentPosition]) {
				//Delay: >d[*.***]
				case BuiltinEscapeCodes.delay: {
					float timeToWait = EscapeCodeUtils.readNumber(message, ref currentPosition);
					returner.cmdOut = new DelayCommand(timeToWait);
					break;
				}
				default:
					currentPosition++;
					returner.cmdOut = null;
					break;
			}

			//Figure out how many spaces we've moved.
			returner.skipDist = currentPosition - startPos;
			
			//Finally, initialize the next write command.
			nextWrite = initializeNextWrite();

			return returner;
		}

		WriteCommand initializeNextWrite() {
			return new WriteCommand();
		}
	}
}
