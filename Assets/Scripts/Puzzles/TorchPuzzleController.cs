using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchPuzzleController : MonoBehaviour
{

    public FireCollide firescriptL;
    public FireCollide firescriptR;
    public GameObject PuzzleDoor;
    private Animator DoorAnimator;
    public AudioSource DoorSource;
    public AudioClip DoorOpen;

    // Start is called before the first frame update
    void Start()
    {

        DoorAnimator = PuzzleDoor.GetComponent<Animator>();

    }

    public void PlayAudioClip()
    {
        if (!DoorSource.isPlaying)
        {
            DoorSource.PlayOneShot(DoorOpen);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (firescriptL.Activated)
        {

            Debug.Log("Left Torch Activated");

        }

        if ( firescriptL.Activated && firescriptR.Activated)
        {


          //  DoorSource.PlayOneShot(DoorOpen, 0.2F);
            DoorAnimator.SetTrigger("Door_Open");
            PlayAudioClip();




        }


    }
}
