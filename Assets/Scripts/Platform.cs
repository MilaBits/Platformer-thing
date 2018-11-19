using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {
    public BottomCheck BottomCheck;

    private Collider2D collider;

    private void Start() {
        collider = GetComponent<Collider2D>();
    }

    void Update() {
        if (BottomCheck.seesPlayer) {
            collider.enabled = false;
            return;
        }

        collider.enabled = true;
    }
}