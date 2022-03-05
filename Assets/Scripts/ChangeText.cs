using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI instructionText;
    public GameObject[] panel;
    int count = 0;


    public void CallChangeText()
    {
        if(count == 0)
        {
            instructionText.text = "1. Change The Color of the Object using the Add Color Dropdown.\n\nObserve how the cube's color changes, this is due to the material's color being changed in the Mesh Renderer.";
            panel[0].SetActive(true);
            panel[1].SetActive(false);
            panel[2].SetActive(false);
            panel[3].SetActive(false);
            panel[4].SetActive(false);
            count++;
        }
        else if(count == 1)
        {
            instructionText.text = "2. Now change the Mesh of the Cube, Observe how the shape changes.\n\n You can pick up the gun from the table and shoot on the Cube, observe how the bullet passes through the shapes and does not hit the cube.";
            panel[0].SetActive(false);
            panel[1].SetActive(true);
            panel[2].SetActive(false);
            panel[3].SetActive(false);
            panel[4].SetActive(false);
            count++;
        }
        else if(count == 2)
        {
            instructionText.text = "3. Now Enable the Collider on the menu and shoot at the object.\n\n You will be able to observe that when you shoot at the object now, the bullet deflects. This is because of the colliders.";
            panel[0].SetActive(false);
            panel[1].SetActive(false);
            panel[2].SetActive(true);
            panel[3].SetActive(false);
            panel[4].SetActive(false);
            count++;
        }
        else if (count == 3)
        {
            instructionText.text = "There are several kinds of Colliders in Unity - Box, Sphere, Capsule, Polygon - We have set Box Collider for Cube, Sphere Collider for Sphere and Capsule Collider for Capsule here, you can play around with the meshes and shoot on the object.";
            panel[0].SetActive(false);
            panel[1].SetActive(false);
            panel[2].SetActive(true);
            panel[3].SetActive(false);
            panel[4].SetActive(false);
            count++;
        }
        else if (count == 4)
        {
            instructionText.text = "Now enable the Rigidbody, while the Collider is enabled.\n\nYou will observe the object fall, change the mesh and try to shoot the object, you will be able to play around with the object.";
            panel[0].SetActive(false);
            panel[1].SetActive(false);
            panel[2].SetActive(false);
            panel[3].SetActive(true);
            panel[4].SetActive(false);
            count++;
        }
        else if (count == 5)
        {
            instructionText.text = "Rigidbody is responsible for the Physics of the object, it helps the object behave like a physical real world object.";
            panel[0].SetActive(false);
            panel[1].SetActive(false);
            panel[2].SetActive(false);
            panel[3].SetActive(true);
            panel[4].SetActive(false);
            count++;
        }
        else if (count == 6)
        {
            instructionText.text = "Try disabling the Collider while Rigidbody, you will see that the object falls, this is because the collider was preventing it to fall from the floor.";
            panel[0].SetActive(false);
            panel[1].SetActive(false);
            panel[2].SetActive(true);
            panel[3].SetActive(true);
            panel[4].SetActive(false);
            count++;
        }
        else if (count == 7)
        {
            instructionText.text = "You can reset the application and play with the object again, or close the application";
            panel[0].SetActive(false);
            panel[1].SetActive(false);
            panel[2].SetActive(false);
            panel[3].SetActive(false);
            panel[4].SetActive(true);
            count++;
        }
        else if (count == 8)
        {
            instructionText.text = "Close Application";
            panel[0].SetActive(false);
            panel[1].SetActive(false);
            panel[2].SetActive(false);
            panel[3].SetActive(false);
            panel[4].SetActive(false);
            count++;
        }
        else if (count == 9)
        {
            Application.Quit();
        }
    }
}
