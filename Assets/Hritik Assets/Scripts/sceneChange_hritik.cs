using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneChange_hritik : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void tutorialScene()
    {
        SceneManager.LoadScene("Create_with_VR_Starter_Scene");

    }


    public void modMenuScene()
    {
        SceneManager.LoadScene("mod_trainer");

    }


    public void gunMechScene()
    {
        SceneManager.LoadScene("Shooting");

    }


    public void basketballScene()
    {
        SceneManager.LoadScene("mod_trainer_game");

    }

    public void goBack()
    {
        SceneManager.LoadScene("main_menu");

    }

}
