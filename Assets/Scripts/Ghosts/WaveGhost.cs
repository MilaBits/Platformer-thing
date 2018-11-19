using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

public class WaveGhost : Ghost {
    
    [InfoBox("Make sure this ghost has a parent Path (Sine component)")]
    private Sine path;
    private int currentTarget = 0;

    private SpriteRenderer spriteRenderer;

    void Start() {
        path = GetComponentInParent<Sine>();

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.flipX = true;
    }

    private void Update() {
        Move();
    }

    private void Move() {
        
        // move towards the target
        transform.position = Vector3.MoveTowards(transform.position, path.points[currentTarget], Speed * Time.deltaTime);

        // set next target if current target was reached
        if (transform.position == path.points[currentTarget]) {
            currentTarget++;
        }

        // end reached, send ghost back
        if (currentTarget >= path.points.Count) {
            currentTarget = 0;
            spriteRenderer.flipX = !spriteRenderer.flipX;
            path.points.Reverse();
        }
    }
}