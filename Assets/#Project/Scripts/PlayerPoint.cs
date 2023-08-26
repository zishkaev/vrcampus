using UnityEngine;

public class PlayerPoint : MonoBehaviour {
	public Transform point;
	public bool returnAtStart;


	private void Start() {
		if (returnAtStart)
			Return();
	}

	public void Return() {
		PlayerController.instance.Warp(point);
	}
}
