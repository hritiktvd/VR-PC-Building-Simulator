using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class rotatingSystem_Hritik : MonoBehaviour
{
    public GameObject cube;
    public GameObject rotateXbutton,rotateYbutton,rotateZbutton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rotateX()
    {

        cube.transform.rotation *= Quaternion.Euler(90f, 0, 0);

    }

    public void rotateY()
    {
        cube.transform.rotation *= Quaternion.Euler(0, 90f, 0);

    }

    public void rotateZ()
    {
        cube.transform.rotation *= Quaternion.Euler(0, 0, 90f);

    }
}
