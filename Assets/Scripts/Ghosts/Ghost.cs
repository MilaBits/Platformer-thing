using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {
    public float Speed;

    private void OnCollisionEnter2D(Collision2D other) {
        foreach (ContactPoint2D hitPos in other.contacts) {
            if (other.gameObject.CompareTag("Player")) {
                CharacterController2D player = other.gameObject.GetComponent<CharacterController2D>();

                Debug.Log("Hitpos: " + hitPos.normal);
                // 0, 1 = down
                // 0, -1 = up
                // 1, 0 = right
                // -1, 0 = left

                // Player is jumping and hitting from below
                if (hitPos.normal.y > .5f && !player.IsGrounded()) {
                    Destroy(gameObject);
                }

                Debug.Log("Lose");
            }
        }
    }
}