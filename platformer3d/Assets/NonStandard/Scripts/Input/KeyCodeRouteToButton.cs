using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace NonStandard {
public class KeyCodeRouteToButton : KeyCodeRoute {

	private Button button;
	private bool on = false;

	void Start() {
		button = GetComponent<Button>();
	}

	void Update () {
		if(key != KeyCode.None) {
			if (Input.GetKeyDown(key) && IsModifiersSatisfied()) {
				button.OnPointerDown(new PointerEventData(EventSystem.current));
				on = true;
			}
			if (Input.GetKeyUp(key) && on) {
				button.OnPointerUp(new PointerEventData(EventSystem.current));
				on = false;
			}
		}
	}
}
}