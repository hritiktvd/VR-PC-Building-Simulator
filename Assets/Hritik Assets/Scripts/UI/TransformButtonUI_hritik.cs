using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformButtonUI_hritik : MonoBehaviour
{
    public GameObject transformButton, transformAttributes;
    private bool isOn, isAdditionalUIOn;

    // Start is called before the first frame update
    void Start()
    {
        transformButton.SetActive(false);
        transformAttributes.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

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
        
    }


    

}
