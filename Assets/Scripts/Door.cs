using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class Door : MonoBehaviour {
    [ShowInInspector] private bool isOpen;

    public Color OpenColor;

    public SpriteRenderer spriteRenderer;

    public void OpenDoor() {
        isOpen = true;

        spriteRenderer.color = OpenColor;
    }
}