using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomCheck : MonoBehaviour {
    public bool seesPlayer;

    private void OnTriggerEnter2D(Collider2D other) {
        seesPlayer = true;
    }

    private void OnTriggerExit2D(Collider2D other) {
        seesPlayer = false;
    }
}