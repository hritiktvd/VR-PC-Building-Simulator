using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingOptionsUI_hritik : MonoBehaviour
{
    public GameObject transformButton,scaleButton,rotateButton,colliderButton;
    public GameObject leftButton,rightButton,upButton;
    public GameObject increaseScaleButton, decreaseButton;
    public GameObject rotateXButton, rotateYButton, rotateZButton;
    public GameObject disableMeshColl,enableMeshColl;
    public GameObject introcont, transformcont, rotatecont, collidercont, scalecont;
    public int transflag = 1;
    public int scaleflag = 1;
    public int rotflag = 1;
    public int collflag = 1;
    // Start is called before the first frame update
    void Start()
    {
        leftButton.SetActive(false);
        rightButton.SetActive(false);
        upButton.SetActive(false);
        increaseScaleButton.SetActive(false);
        decreaseButton.SetActive(false);
        rotateXButton.SetActive(false);
        rotateYButton.SetActive(false);
        rotateZButton.SetActive(false);
        disableMeshColl.SetActive(false);
        enableMeshColl.SetActive(false);
        introcont.SetActive(true);
        transformcont.SetActive(false);
        rotatecont.SetActive(false);
        collidercont.SetActive(false);
        scalecont.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showTransformControls()
    {
        if (transformButton == true)
        {
            if (transflag == 1)
            {
                leftButton.SetActive(true);
                rightButton.SetActive(true);
                upButton.SetActive(true);
                increaseScaleButton.SetActive(false);
                decreaseButton.SetActive(false);
                rotateXButton.SetActive(false);
                rotateYButton.SetActive(false);
                rotateZButton.SetActive(false);
                disableMeshColl.SetActive(false);
                enableMeshColl.SetActive(false);
                introcont.SetActive(false);
                transformcont.SetActive(true);
                rotatecont.SetActive(false);
                collidercont.SetActive(false);
                scalecont.SetActive(false);
                transflag = 0;

            }

            else if (transflag == 0)
            {
                leftButton.SetActive(false);
                rightButton.SetActive(false);
                upButton.SetActive(false);
                increaseScaleButton.SetActive(false);
                decreaseButton.SetActive(false);
                rotateXButton.SetActive(false);
                rotateYButton.SetActive(false);
                rotateZButton.SetActive(false);
                disableMeshColl.SetActive(false);
                enableMeshColl.SetActive(false);
                introcont.SetActive(false);
                transformcont.SetActive(true);
                rotatecont.SetActive(false);
                collidercont.SetActive(false);
                scalecont.SetActive(false);
                transflag = 1;
            }
        }

    }

    public void showScaleControls()
    {
        if(scaleButton == true)
        {
            if(scaleflag == 1)
            {
                leftButton.SetActive(false);
                rightButton.SetActive(false);
                upButton.SetActive(false);
                increaseScaleButton.SetActive(true);
                decreaseButton.SetActive(true);
                rotateXButton.SetActive(false);
                rotateYButton.SetActive(false);
                rotateZButton.SetActive(false);
                disableMeshColl.SetActive(false);
                enableMeshColl.SetActive(false);
                introcont.SetActive(false);
                transformcont.SetActive(false);
                rotatecont.SetActive(false);
                collidercont.SetActive(false);
                scalecont.SetActive(true);
                scaleflag = 0;
            }

            else if (scaleflag == 0)
            {
                leftButton.SetActive(false);
                rightButton.SetActive(false);
                upButton.SetActive(false);
                increaseScaleButton.SetActive(false);
                decreaseButton.SetActive(false);
                rotateXButton.SetActive(false);
                rotateYButton.SetActive(false);
                rotateZButton.SetActive(false);
                disableMeshColl.SetActive(false);
                enableMeshColl.SetActive(false);
                introcont.SetActive(false);
                transformcont.SetActive(false);
                rotatecont.SetActive(false);
                collidercont.SetActive(false);
                scalecont.SetActive(true);
                scaleflag = 1;
            }
        }
    }

    public void showRotateControls()
    {
        if(rotateButton == true)
        {
            if(rotflag == 1)
            {
                leftButton.SetActive(false);
                rightButton.SetActive(false);
                upButton.SetActive(false);
                increaseScaleButton.SetActive(false);
                decreaseButton.SetActive(false);
                rotateXButton.SetActive(true);
                rotateYButton.SetActive(true);
                rotateZButton.SetActive(true);
                disableMeshColl.SetActive(false);
                enableMeshColl.SetActive(false);
                introcont.SetActive(false);
                transformcont.SetActive(false);
                rotatecont.SetActive(true);
                collidercont.SetActive(false);
                scalecont.SetActive(false);
                rotflag = 0;
            }


            else if (rotflag == 0)
            {
                leftButton.SetActive(false);
                rightButton.SetActive(false);
                upButton.SetActive(false);
                increaseScaleButton.SetActive(false);
                decreaseButton.SetActive(false);
                rotateXButton.SetActive(false);
                rotateYButton.SetActive(false);
                rotateZButton.SetActive(false);
                disableMeshColl.SetActive(false);
                enableMeshColl.SetActive(false);
                introcont.SetActive(false);
                transformcont.SetActive(false);
                rotatecont.SetActive(true);
                collidercont.SetActive(false);
                scalecont.SetActive(false);
                rotflag = 1;
            }
        }
    }

    public void showMeshCollider()
    {
        if (colliderButton)
        {
            if(collflag == 1)
            {
                leftButton.SetActive(false);
                rightButton.SetActive(false);
                upButton.SetActive(false);
                increaseScaleButton.SetActive(false);
                decreaseButton.SetActive(false);
                rotateXButton.SetActive(false);
                rotateYButton.SetActive(false);
                rotateZButton.SetActive(false);
                disableMeshColl.SetActive(true);
                enableMeshColl.SetActive(true);
                introcont.SetActive(false);
                transformcont.SetActive(false);
                rotatecont.SetActive(false);
                collidercont.SetActive(true);
                scalecont.SetActive(false);
                collflag = 0;
            }

            else if(collflag == 0)
            {
                leftButton.SetActive(false);
                rightButton.SetActive(false);
                upButton.SetActive(false);
                increaseScaleButton.SetActive(false);
                decreaseButton.SetActive(false);
                rotateXButton.SetActive(false);
                rotateYButton.SetActive(false);
                rotateZButton.SetActive(false);
                disableMeshColl.SetActive(false);
                enableMeshColl.SetActive(false);
                introcont.SetActive(false);
                transformcont.SetActive(false);
                rotatecont.SetActive(false);
                collidercont.SetActive(true);
                scalecont.SetActive(false);
                collflag = 1;
            }
        }
    }

}
