using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;

public class Scale : MonoBehaviour
{
    
    private bool isObjectGrabbed, scaleObjectUp, scaleObjectDown;
    private bool isPrimaryButtonPressed, isSecondaryButtonPressed;
    private float speedOfScaling = 2.0f;

    public UnityEngine.InputSystem.InputActionReference rightPrimaryButtonPressed, rightSecondaryButtonPressed, leftPrimaryButtonPressed, leftSecondaryButtonPressed;


    private void Start()
    {
        rightPrimaryButtonPressed.action.performed += RightPrimaryButtonPressed;
        rightPrimaryButtonPressed.action.canceled += RightPrimaryButtonReleased;

        rightSecondaryButtonPressed.action.performed += RightSecondaryButtonPressed;
        rightSecondaryButtonPressed.action.canceled += RightSecondaryButtonReleased;

        leftPrimaryButtonPressed.action.performed += LeftPrimaryButtonPressed;
        leftPrimaryButtonPressed.action.canceled += LeftPrimaryButtonReleased;

        leftSecondaryButtonPressed.action.performed += LeftSecondaryButtonPressed;
        leftSecondaryButtonPressed.action.canceled += LeftSecondaryButtonReleased;


    }

    private void LeftSecondaryButtonReleased(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        isSecondaryButtonPressed = false;
        
    }

    private void LeftSecondaryButtonPressed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        isSecondaryButtonPressed = true;
        Debug.Log("LeftSecondaryButtonPressed");
    }

    private void LeftPrimaryButtonReleased(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        isPrimaryButtonPressed = false;

    }

    private void LeftPrimaryButtonPressed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        isPrimaryButtonPressed = true;
        Debug.Log("LeftPrimaryButtonPressed");
    }

    private void RightSecondaryButtonReleased(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        isSecondaryButtonPressed = false;
    }

    private void RightSecondaryButtonPressed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        isSecondaryButtonPressed = true;
        Debug.Log("RightSecondaryButtonPressed");
    }

    private void RightPrimaryButtonReleased(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        isPrimaryButtonPressed = false;
    }

    private void RightPrimaryButtonPressed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        isPrimaryButtonPressed = true;
        Debug.Log("RightPrimaryButtonPressed");
    }

    private void Update()
    {
        if(isPrimaryButtonPressed && isObjectGrabbed)
        {
            this.transform.localScale -= this.transform.localScale * speedOfScaling * Time.deltaTime;
            Debug.Log("Scaling Down");
        }

        if(isSecondaryButtonPressed && isObjectGrabbed)
        {
            this.transform.localScale += this.transform.localScale * speedOfScaling * Time.deltaTime;
            Debug.Log("Scaling Up");
        }
        


    }

    

    

    public void ObjectSelected()
    {
        isObjectGrabbed = true;
    }

    public void ObjectDeselected()
    {
        isObjectGrabbed = false;
    }

    private void OnEnable()
    {
        //scaleUp.Enable();
    }

    private void OnDisable()
    {
        //scaleUp.Disable();
    }
}
