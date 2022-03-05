using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialManager : MonoBehaviour
{

    private AudioSource audioSource;
    [SerializeField]
    [Tooltip("The list of audio clips to play from")]
    public List<AudioClip> audioClips = new List<AudioClip>();
    private int audioClipCounter, tutorialStepCounter, objectsPickedUpCounter;
    private bool stepOneCompleted, stepTwoCompleted;

    public List<GameObject> gameObjectsToMakeVisible = new List<GameObject>();
    public List<GameObject> tutorialResources = new List<GameObject>();

    public TextMeshProUGUI objectsPickedUpText;

    private bool one, two, three, four, oneComplement, twoComplement, threeComplement, fourComplement;

    public ToggleRay toggleRayRightHand, toggleRayLeftHand;



    // Start is called before the first frame update
    void Start()
    {
        tutorialStepCounter = 0;
        objectsPickedUpCounter = 0;
        audioClipCounter = 0;

        foreach (var item in gameObjectsToMakeVisible)
        {
            item.SetActive(false);
        }

        foreach (var item in tutorialResources)
        {
            item.SetActive(false);
        }

        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClips[Mathf.Abs(audioClipCounter)];
        audioSource.PlayDelayed(3f);
        StartCoroutine(PlaySecondAudioClip());
    }

    IEnumerator PlaySecondAudioClip()
    {
        yield return new WaitForSeconds(audioSource.clip.length + 5);
        audioClipCounter++;

        audioSource.clip = audioClips[audioClipCounter];
        audioSource.Play();

        //Initialize table and a tutorial wallpaper with instructions. 

        //Adding a small wait timer before spawnning the task. 

        
        yield return new WaitForSeconds(3f);
        //Have some animation and slowly move the objects near the player. 

        gameObjectsToMakeVisible[tutorialStepCounter].SetActive(true);
        tutorialResources[tutorialStepCounter].SetActive(true);

    }

    public void UpdateCountOfObjectsPickedUp(GameObject obj)
    {

        if(obj.name == "Torch" && !one)
        {
            objectsPickedUpCounter++;
            objectsPickedUpText.text = objectsPickedUpCounter.ToString() + "/4";
            one = true;
        }

        if (obj.name == "Cube" && !two)
        {
            objectsPickedUpCounter++;
            objectsPickedUpText.text = objectsPickedUpCounter.ToString() + "/4";
            two = true;
        }

        if (obj.name == "Mirror" && !three)
        {
            objectsPickedUpCounter++;
            objectsPickedUpText.text = objectsPickedUpCounter.ToString() + "/4";
            three = true;
        }

        if (obj.name == "Bin" && !four)
        {
            objectsPickedUpCounter++;
            objectsPickedUpText.text = objectsPickedUpCounter.ToString() + "/4";
            four = true;
        }


        //


    }

    private int trackObjectCounter = 0;
    public void TrackCountOfObjectsPickedUp(GameObject obj)
    {
        if (obj.name == "Torch" && !oneComplement)
        {
            trackObjectCounter++;
            oneComplement = true;
        }

        if (obj.name == "Cube" && !twoComplement)
        {
            trackObjectCounter++;
            twoComplement = true;
        }

        if (obj.name == "Mirror" && !threeComplement)
        {
            trackObjectCounter++;
            threeComplement = true;
        }

        if (obj.name == "Bin" && !fourComplement)
        {
            trackObjectCounter++;
            fourComplement = true;
        }

        //Debug.Log(objectsPickedUpCounter + " " + trackObjectCounter);
        if (objectsPickedUpCounter == 4 && trackObjectCounter == 4) StartCoroutine(PlayThirdAudioClip());
    }



    IEnumerator PlayThirdAudioClip()
    {
        
        //Intro to second task 
        audioClipCounter++;
        audioSource.clip = audioClips[audioClipCounter];
        audioSource.Play();

        yield return new WaitForSeconds(audioSource.clip.length - 2f);
        //Deactivate the task related resources. 

        gameObjectsToMakeVisible[tutorialStepCounter].SetActive(false);
        tutorialResources[tutorialStepCounter].SetActive(false);
        tutorialStepCounter++;

        yield return new WaitForSeconds(2f);
        //Second task 
        audioClipCounter++;
        audioSource.clip = audioClips[audioClipCounter];
        audioSource.volume = 0.7f;
        audioSource.Play();

        //Toggle the ray hands instead of direct controller. 

        toggleRayLeftHand.ToggleInteractors();
        toggleRayRightHand.ToggleInteractors();

        gameObjectsToMakeVisible[tutorialStepCounter].SetActive(true);
        //tutorialResources[tutorialStepCounter - 1].SetActive(true);



        yield return null;

    }

    // Update is called once per frame
    

    
}
