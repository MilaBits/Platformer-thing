using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class Key : MonoBehaviour {
    [Required] public Door Door;

    private void OnTriggerEnter2D(Collider2D other) {
        Door.OpenDoor();

        gameObject.SetActive(false);
    }
}