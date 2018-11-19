using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class Sine : MonoBehaviour {
    [OnValueChanged("Draw")] [Range(1, 30)]
    public int distance = 3;

    [OnValueChanged("Draw")] [Range(.01f, 1f)] [Tooltip("horizontal space between line segments")]
    public float resolution = .2f;

    [OnValueChanged("Draw")] [Range(-5f, 5f)] [Tooltip("offset to the sine wave starting point")]
    public float offset = 0;

    [OnValueChanged("Draw")] [Range(0f, 5f)] [Tooltip("period length")]
    public float wavelength = 1f;

    [OnValueChanged("Draw")] [Range(0f, 5f)] [Tooltip("height of the sine wave")]
    public float amplitude = 1f;

    [ReadOnly] public List<Vector3> points = new List<Vector3>();

    void Start() {
        Draw();
    }

    private void Draw() {
        points.Clear();

        for (int i = 0; i * resolution < distance; i++) {
            Vector3 pos = transform.position +
                          new Vector3(i * resolution, amplitude * Mathf.Sin(i * resolution * wavelength), 0);

            points.Add(pos);
        }

        points.RemoveAt(points.Count - 1);
    }
}