using UnityEngine;

namespace NonStandard {
public class LeaveParent : MonoBehaviour {
	void Start () {
		transform.SetParent(null);
	}
}
}