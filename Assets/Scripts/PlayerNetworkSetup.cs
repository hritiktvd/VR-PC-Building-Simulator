using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerNetworkSetup : MonoBehaviourPunCallbacks
{
    public GameObject localXRRigObject;

    public GameObject AvatarHeadObject;
    public GameObject AvatarBodyObject;
    void Start()
    {
        if (photonView.IsMine)
        {
            localXRRigObject.SetActive(true);
            SetLayerRecursively(AvatarHeadObject, 6);
            SetLayerRecursively(AvatarBodyObject, 7);
        }
        else
        {
            localXRRigObject.SetActive(false);
            SetLayerRecursively(AvatarHeadObject, 0);
            SetLayerRecursively(AvatarBodyObject, 0);
        }
    }

    
    void Update()
    {
        
    }
    void SetLayerRecursively(GameObject go, int layerNumber)
    {
        if (go == null) return;
        foreach (Transform trans in go.GetComponentsInChildren<Transform>(true))
        {
            trans.gameObject.layer = layerNumber;
        }
    }
}
