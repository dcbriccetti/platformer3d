using UnityEngine;

namespace NonStandard {
	public class KeyCodeRoute : UserControl {
		[Tooltip("The key being focused on by this script")]
		public KeyCode key = KeyCode.None;
		public KeyModifier[] modifiers;

		public bool IsModifiersSatisfied() {
			return IsModifiersSatisfied(modifiers);
		}
	}
}