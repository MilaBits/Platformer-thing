using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalGhost : Ghost {
    private Transform Target;

    private void Start() {
        Target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update() {
        Move();
    }

    private void Move() {
        transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
    }
}