using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class RigidbodyEnable : MonoBehaviour
{
    public GameObject cube;
    public TextMeshProUGUI buttonText;
    public TextMeshProUGUI button2Text;
    public bool enableRigidbody;
    public bool enableCollider;
    public TMP_Dropdown dropdown;
    public TMP_Dropdown dropdown2;
    public Mesh[] meshes;
    int dropdownValue;
    int dropdown2Value;
    // Start is called before the first frame update
    void Start()
    {
        enableRigidbody = true;
        enableCollider = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enableRigidbodyCube()
    {
        if (enableRigidbody)
        {
            buttonText.text = "No";
            cube.AddComponent<Rigidbody>();
            enableRigidbody = false;
        }
        else
        {
            buttonText.text = "Yes";
            Destroy(cube.GetComponent<Rigidbody>());
            enableRigidbody = true;
        }
       
    }

    public void ChangeCubeShape()
    {
        MeshFilter yourMesh = cube.GetComponent<MeshFilter>();
        dropdownValue = dropdown.value;
        if (dropdown.options[dropdownValue].text.Equals("Cube")){
            yourMesh.sharedMesh = meshes[0];
            if(button2Text.text == "No"){
                cube.AddComponent<BoxCollider>();
                Destroy(cube.GetComponent<SphereCollider>());
                Destroy(cube.GetComponent<CapsuleCollider>());
            }
        }
        if (dropdown.options[dropdownValue].text.Equals("Sphere"))
        {
            yourMesh.sharedMesh = meshes[1];
            if (button2Text.text == "No")
            {
                cube.AddComponent<SphereCollider>();
                Destroy(cube.GetComponent<BoxCollider>());
                Destroy(cube.GetComponent<CapsuleCollider>());
            }
        }
        if (dropdown.options[dropdownValue].text.Equals("Capsule"))
        {
            yourMesh.sharedMesh = meshes[2];
            if (button2Text.text == "No")
            {
                cube.AddComponent<CapsuleCollider>();
                Destroy(cube.GetComponent<BoxCollider>());
                Destroy(cube.GetComponent<SphereCollider>());
            }
        }
    }

    public void AddCollider()
    {
        if (enableCollider)
        {
            button2Text.text = "No";
            if (dropdown.options[dropdownValue].text.Equals("Cube"))
            {
                cube.AddComponent<BoxCollider>();
                Destroy(cube.GetComponent<SphereCollider>());
                Destroy(cube.GetComponent<CapsuleCollider>());
            }
            else if (dropdown.options[dropdownValue].text.Equals("Sphere"))
            {
                cube.AddComponent<SphereCollider>();
                Destroy(cube.GetComponent<BoxCollider>());
                Destroy(cube.GetComponent<CapsuleCollider>());
            }
            else if(dropdown.options[dropdownValue].text.Equals("Capsule"))
            {
                cube.AddComponent<CapsuleCollider>();
                Destroy(cube.GetComponent<BoxCollider>());
                Destroy(cube.GetComponent<SphereCollider>());
            }
            enableCollider = false;
        }
        else
        {
            button2Text.text = "Yes";
            Destroy(cube.GetComponent<BoxCollider>());
            Destroy(cube.GetComponent<SphereCollider>());
            Destroy(cube.GetComponent<CapsuleCollider>());
            enableCollider = true;
        }
       
    }

    public void ChangeColor()
    {
        dropdown2Value = dropdown2.value;
        if(dropdown2.options[dropdown2Value].text.Equals("Red"))
        {
            cube.GetComponent<Renderer>().material.color = Color.red;
        }
        if (dropdown2.options[dropdown2Value].text.Equals("Blue"))
        {
            cube.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (dropdown2.options[dropdown2Value].text.Equals("Green"))
        {
            cube.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    public void ResetLevel()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
