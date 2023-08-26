using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
	public Transform movable;

	private void Awake() {
		instance = this;
	}

	public void Warp(Transform point) {
		movable.position = point.position;
		movable.rotation = point.rotation;
	}
}
