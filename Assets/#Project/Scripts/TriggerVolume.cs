using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerVolume : MonoBehaviour {
	public bool playerTrigger;

	public UnityEvent onTriggerEnter, onTriggerExit;

	private void OnTriggerEnter(Collider other) {
		if (playerTrigger) {
			if (other.gameObject.layer != (int)FlaggedLayer.Character)
				return;
			var pc = other.GetComponentInParent<PlayerController>();
			if (pc != null) {
				onTriggerEnter?.Invoke();
			}
		}
		else
			onTriggerEnter?.Invoke();
	}

	private void OnTriggerExit(Collider other) {
		if (playerTrigger) {
			var pc = other.GetComponentInParent<PlayerController>();
			if (pc != null) {
				onTriggerExit?.Invoke();
			}
		}
		else
			onTriggerExit?.Invoke();
	}
}

public enum FlaggedLayer {
	Default = 0,
	Raycast = 2,
	Character = 9
}

