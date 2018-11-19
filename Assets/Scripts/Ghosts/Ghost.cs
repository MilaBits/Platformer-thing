using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {
    public float Speed;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.GetComponent<CharacterController2D>()) {
            CharacterController2D player = other.gameObject.GetComponent<CharacterController2D>();
            if (!player.IsGrounded()) {
                Destroy(gameObject);
            }
        }
    }
}