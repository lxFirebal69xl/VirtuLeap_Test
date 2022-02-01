using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TorchPuzzleController : MonoBehaviour
{
    public Text Progresstext;
    public FireCollide firescriptL;
    public FireCollide firescriptR;
    public GameObject PuzzleDoor;
    private Animator DoorAnimator;
    public AudioSource DoorSource;
    public AudioClip DoorOpen;
    private bool DoorOpened = false;

    // Start is called before the first frame update
    void Start()
    {

        DoorAnimator = PuzzleDoor.GetComponent<Animator>();

    }

    public void PlayAudioClip()
    {

        Progresstext.text = "Puzzles 1/3";

        if (!DoorSource.isPlaying)
        {
            DoorSource.PlayOneShot(DoorOpen);
            DoorOpened = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (firescriptL.Activated)
        {

            Debug.Log("Left Torch Activated");

        }

        if ( firescriptL.Activated && firescriptR.Activated && DoorOpened == false)
        {


          //  DoorSource.PlayOneShot(DoorOpen, 0.2F);
            DoorAnimator.SetTrigger("Door_Open");
            PlayAudioClip();




        }


    }
}
