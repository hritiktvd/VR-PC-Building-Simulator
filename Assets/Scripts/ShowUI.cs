using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUI : MonoBehaviour
{
    public GameObject canvas;
    private bool isOn;


    // Start is called before the first frame update
    void Start()
    {
        canvas.gameObject.SetActive(false);
    }

    public void ShowComponents()
    {
        canvas.gameObject.SetActive(true);
        //Debug.Log("Called");
    }

    public void HideComponents()
    {
        canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
