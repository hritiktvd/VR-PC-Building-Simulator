using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalingSystem_hritik : MonoBehaviour
{
    public GameObject cube;
    public GameObject inccreaseScaleButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseScale()
    {
        cube.gameObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);

    }

    public void decreaseScale()
    {
        cube.gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);

    }

    public void increaseBallScale()
    {
        cube.gameObject.transform.localScale += new Vector3(1.0f, 1.0f, 1.0f);

    }

    public void decreaseBallScale()
    {
        cube.gameObject.transform.localScale -= new Vector3(1.0f, 1.0f, 1.0f);

    }
}
