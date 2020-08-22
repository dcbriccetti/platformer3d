using UnityEngine;

namespace NonStandard {
public class AxisRoute : UserControl
{
	[Tooltip("Horizontal, Vertical, Mouse ScrollWheel, Mouse X, Mouse  Y, ...")]
	public string axis = "";
	public KeyModifier[] modifiers;

	public bool IsModifiersSatisfied()
	{
		return IsModifiersSatisfied(modifiers);
	}
}
}