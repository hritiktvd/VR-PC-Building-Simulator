using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.SceneManagement;


public class LobbyBehaviour : MonoBehaviourPunCallbacks
{
    [Header("Login UI")]
    public GameObject uILoginGameObject;

    [Header("Lobby UI")]
    public GameObject uI_LobbyGameObject;


    [Header("Connection Status UI")]
    public GameObject uI_Connection_Status;
    public Text connection_Text;
    
    bool ShowConnectionStatus;

   
    void Start()
    {
        uILoginGameObject.SetActive(true);
        uI_LobbyGameObject.SetActive(false);
        uI_Connection_Status.SetActive(false);
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    
    void Update()
    {
        if (ShowConnectionStatus)
        {
            connection_Text.text = "Connection Status: " + PhotonNetwork.NetworkClientState;
        }
       
    }


    #region UI Callback Methods
    public void OnEnterGameButtonClicked()
    {
        string playerName = "User_"+Random.Range(1,1000);
        if (!string.IsNullOrEmpty(playerName))
        {
            uILoginGameObject.SetActive(false);
            uI_LobbyGameObject.SetActive(false);
            uI_Connection_Status.SetActive(true);

            ShowConnectionStatus = true;

            if (!PhotonNetwork.IsConnected)
            {
                PhotonNetwork.LocalPlayer.NickName = playerName;

                PhotonNetwork.ConnectUsingSettings();
            }
            else
            {
                Debug.Log("Player Name is Invalid");
            }
        }
    }


    public void OnQuickMatchClicked()
    {
        PhotonNetwork.JoinRandomRoom();
        
        
    }
    #endregion


    #region Photon Callback Methods
    public override void OnConnected()
    {
        Debug.Log("We connected to Internet");

    }

    public override void OnConnectedToMaster()
    {
        Debug.Log(PhotonNetwork.LocalPlayer.NickName + " is connected to Photon Server");
        uILoginGameObject.SetActive(false);
        uI_LobbyGameObject.SetActive(true);
        uI_Connection_Status.SetActive(false);

    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log(message);
        CreateAndJoinRoom();
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("A room is created: " + PhotonNetwork.CurrentRoom);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("The Local player: " + PhotonNetwork.NickName + " joined to " + PhotonNetwork.CurrentRoom.Name + " Player count " + PhotonNetwork.CurrentRoom.PlayerCount);
        PhotonNetwork.LoadLevel("SampleScene");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(newPlayer.NickName+ " joined to: "+"Player count: " + PhotonNetwork.CurrentRoom.PlayerCount);
    }
    #endregion

    #region Private Methods
    private void CreateAndJoinRoom()
    {
        string randomoomName = "Room_1000";
        RoomOptions room = new RoomOptions();
        room.MaxPlayers = 20;
        PhotonNetwork.CreateRoom(randomoomName, room);
    }
    #endregion
}
