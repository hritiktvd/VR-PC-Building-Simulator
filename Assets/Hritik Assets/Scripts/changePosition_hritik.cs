using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//var startPos : Vector3;
//var startRot : Quaternion;


public class changePosition_hritik : MonoBehaviour
{
    public Vector3 startPos;
    public Quaternion startRot;
    public GameObject cube;
    public GameObject sizeUpButton, sizeDownButton;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        startRot = transform.rotation;
        sizeDownButton.SetActive(false);
        sizeUpButton.SetActive(false);
        rb = cube.GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resetObject()
    {
        print("Reset to Original Scale");
        cube.gameObject.transform.localScale = new Vector3(1.0f,1.0f,1.0f);
        cube.gameObject.transform.localPosition = new Vector3(-2.25f, 0.49f, -2.25f);
        cube.gameObject.transform.localRotation = startRot;
        //transform.position = startPos;
        //transform.rotation = startRot;

    }

    public void resetBallObject()
    {
        print("Reset to Original Scale");
        cube.gameObject.transform.localScale = new Vector3(11.25f, 11.25f, 11.25f);
        cube.gameObject.transform.localPosition = new Vector3(0.0f, 1.5f, 0.0f);
        cube.gameObject.transform.localRotation = startRot;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        //transform.position = startPos;
        //transform.rotation = startRot;

    }

    public void moveLeft()
    {
        sizeDownButton.SetActive(false);
        sizeUpButton.SetActive(false);
        cube.transform.Translate(Vector3.left, Space.World);

    }

    public void moveRight()
    {
        sizeDownButton.SetActive(false);
        sizeUpButton.SetActive(false);
        cube.transform.Translate(Vector3.right, Space.World);
    }

    public void moveUp()
    {
        sizeDownButton.SetActive(false);
        sizeUpButton.SetActive(false);
        cube.transform.Translate(Vector3.up, Space.World);
    }
    public void disableMeshColl()
    {
        sizeDownButton.SetActive(false);
        sizeUpButton.SetActive(false);
        cube.transform.Translate(Vector3.down, Space.World);
    }

}
