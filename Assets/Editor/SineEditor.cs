using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Sine))]
public class SineEditor : Editor {
    private void OnSceneGUI() {
        Sine sine = (Sine) target;

        List<Vector3> points = new List<Vector3>();
        
        for (int i = 0; i * sine.resolution < sine.distance; i++) {
            Vector3 pos = sine.transform.position + new Vector3(i * sine.resolution, sine.amplitude * Mathf.Sin(i * sine.resolution * sine.wavelength), 0);            
            points.Add(pos);
        }
        
        for (int i = 0; i < points.Count; i++) {
            if (i+1 < points.Count)
            Handles.DrawLine(points[i], points[i+1]);
        }
    }
}