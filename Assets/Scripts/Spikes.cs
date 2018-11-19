using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour {

	private void OnCollisionEnter2D(Collision2D other) {
		foreach (ContactPoint2D hitPos in other.contacts) {
			if (other.gameObject.CompareTag("Player")) {
				CharacterController2D player = other.gameObject.GetComponent<CharacterController2D>();

				Debug.Log("Hitpos: " + hitPos.normal);
				// 0, 1 = down
				// 0, -1 = up
				// 1, 0 = right
				// -1, 0 = left

				// Player hit top of spikes
				if (hitPos.normal.y < -.5f) {
					Debug.Log("Lose");
				}
			}
		}
	}
}
