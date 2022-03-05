using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject transformButton, transformAttributes, panelForTransformAttributes, triggerImageHelp;
    private bool isOn, isAdditionalUIOn;

    // Start is called before the first frame update
    void Start()
    {
        transformButton.SetActive(false);
        transformAttributes.SetActive(false);
        panelForTransformAttributes.SetActive(false);
        triggerImageHelp.SetActive(false);
    }

    
    public void ToggleButton()
    {
        isOn = !isOn;
        transformButton.SetActive(isOn);
    }

    public void ShowButton()
    {
        isOn = true;
        transformButton.SetActive(isOn);
    }

    public void HideButton()
    {
        isOn = false;
        transformButton.SetActive(isOn);
    }

    public void ButtonClick()
    {
        isAdditionalUIOn = !isAdditionalUIOn;
        transformAttributes.SetActive(isAdditionalUIOn);
        panelForTransformAttributes.SetActive(isAdditionalUIOn);
        
    }

    //This function shows the image for trigger button help in the second task. 
    public void ShowTriggerButtonImage()
    {
        triggerImageHelp.SetActive(true);
    }

    public void HideTriggerButtonImage()
    {
        triggerImageHelp.SetActive(false);
    }




}
