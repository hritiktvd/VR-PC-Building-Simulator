using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWithObjects_hritik : MonoBehaviour
{
    GUIContent content = new GUIContent();
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public Texture2D btntexture, redbulltexture, merctexture, mclarentexture;
    public float hSliderValue = 0.0F;
    public GameObject temp1, temp2, temp3;
    public Vector3 coords;
    public string coordinates, textinfo;
    public int flag = 1;
    public string rotation = "Rotate Car";
    public string Redbull = "Red Bull Livery";
    GUIStyle largeFont;
    //public AudioSource audioSource;
    //public AudioClip mySound;


    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<Material>().
        content.image = (Texture2D)btntexture;
        largeFont = new GUIStyle();
        largeFont.fontSize = 45;
        //audioSource.Stop();
        //audioSource.Play();


    }

    // Update is called once per frame
    void Update()
    {
        obj1.transform.rotation = Quaternion.Euler(0, hSliderValue, 0);
        coords = obj1.transform.position;
        coordinates = coords.ToString();

        //if (flag == 1)
        //{
        //    audioSource.PlayOneShot(mySound);

        //}

    }

    private void OnGUI()
    {
        GUI.skin.button.normal.background = (Texture2D)content.image;
        GUI.skin.button.hover.background = (Texture2D)content.image;
        GUI.skin.button.active.background = (Texture2D)content.image;

        hSliderValue = GUI.HorizontalSlider(new Rect(760, 940, 500, 60), hSliderValue, 0.0F, -359.0F);
        if (flag == 1)
        {
            textinfo = GUI.TextArea(new Rect(840, 1020, 105, 20), coordinates, largeFont);
            textinfo = GUI.TextArea(new Rect(900, 960, 70, 22), rotation, largeFont);

        }
        if (GUI.Button(new Rect(80, 860, 150, 90), "Add"))
        {
            obj1.SetActive(true);
        }

        if (GUI.Button(new Rect(80, 965, 150, 90), "Remove"))
        {
            obj1.SetActive(false);
        }

        if (GUI.Button(new Rect(545, 860, 150, 55), "Red Bull Livery"))
        {
            obj1.GetComponent<Renderer>().material.mainTexture = redbulltexture;

        }

        if (GUI.Button(new Rect(545, 1000, 150, 55), "Pastel Livery"))
        {
            obj1.GetComponent<Renderer>().material.mainTexture = merctexture;
        }
        if (GUI.Button(new Rect(545, 930, 150, 55), "Orange Livery"))
        {
            obj1.GetComponent<Renderer>().material.mainTexture = mclarentexture;
        }

        if (GUI.Button(new Rect(310, 860, 150, 90), "Increase Size"))
        {
            obj1.gameObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }

        if (GUI.Button(new Rect(310, 965, 150, 90), "Reduce Size"))
        {
            obj1.gameObject.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
        }
        if (GUI.Button(new Rect(1360, 880, 150, 150), "Move Left"))
        {
            obj1.transform.Translate(Vector3.forward, Space.World);
        }
        if (GUI.Button(new Rect(1740, 880, 150, 150), "Move Right"))
        {
            obj1.transform.Translate(Vector3.back, Space.World);
        }
        if (GUI.Button(new Rect(1550, 965, 150, 65), "Move Back"))
        {
            obj1.transform.Translate(Vector3.right, Space.World);
        }
        if (GUI.Button(new Rect(1550, 880, 150, 65), "Move Forward"))
        {
            obj1.transform.Translate(Vector3.left, Space.World);
        }
        //if (GUI.Button(new Rect(10, 220, 100, 90), "Destroy"))
        //{
        //    Destroy(obj1);
        //}
    }
}
