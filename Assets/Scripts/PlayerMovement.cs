using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour {
    public CharacterController2D Controller;

    public float runSpeed = 40;


    float horizontalMove = 0;
    private bool jump = false;

    void Start() {
    }

    void Update() {
        
        if (CrossPlatformInputManager.GetButtonDown("Left")) horizontalMove = -1 * runSpeed;
        
        if (CrossPlatformInputManager.GetButtonDown("Right")) horizontalMove = 1 * runSpeed;
        
        if (CrossPlatformInputManager.GetButtonDown("Jump")) jump = true;
        
        
        if (CrossPlatformInputManager.GetButtonUp("Right") || CrossPlatformInputManager.GetButtonUp("Left")) horizontalMove = 0;
    }

    void FixedUpdate() {
        Debug.Log(horizontalMove);
        Controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}