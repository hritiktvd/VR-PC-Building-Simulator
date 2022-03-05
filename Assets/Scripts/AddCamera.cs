using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCamera : MonoBehaviour
{
    public Camera MyCamera;
    public Canvas MyCanvas;
    // Start is called before the first frame update
    void Start()
    {
        MyCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();

        MyCanvas.worldCamera = MyCamera;

    }

    // Update is called once per frame
    void Update()
    {
        MyCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();

        MyCanvas.worldCamera = MyCamera;
    }
}
