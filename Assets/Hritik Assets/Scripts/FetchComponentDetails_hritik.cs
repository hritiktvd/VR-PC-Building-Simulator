    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class FetchComponentDetails_hritik : MonoBehaviour
{
    public TextMeshProUGUI positionX, positionY, positionZ, rotationX, rotationY, rotationZ, scaleX, scaleY, scaleZ;
    public GameObject currentObject;

    private float num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetPosition();
        SetRotation();
        SetScale();
    }

    private void SetScale()
    {
        scaleX.text = string.Format("{0:0.0}", currentObject.transform.localScale.x);
        scaleY.text = string.Format("{0:0.0}",currentObject.transform.localScale.y);
        scaleZ.text = string.Format("{0:0.0}", currentObject.transform.localScale.z);
    }

    private void SetRotation()
    {
        rotationX.text = string.Format("{0:0.0}", currentObject.transform.rotation.x);
        rotationY.text = string.Format("{0:0.0}", currentObject.transform.rotation.y);
        rotationZ.text = string.Format("{0:0.0}", currentObject.transform.rotation.z);
    }

    private void SetPosition()
    {
        positionX.text = string.Format("{0:0.0}", currentObject.transform.position.x);
        positionY.text = string.Format("{0:0.0}", currentObject.transform.position.y);
        positionZ.text = string.Format("{0:0.0}", currentObject.transform.position.z);
    }
}
