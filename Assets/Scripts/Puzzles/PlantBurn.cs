using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantBurn : MonoBehaviour
{
    public DissolveEffect dissolve;
    public AudioSource BurningSource;
    public AudioClip LeavesBurning;
    public Text Progresstext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fireball")
        {

            Debug.Log(other);
            dissolve.activate = true;
            PlayAudioClip();

        }
    }

    public void PlayAudioClip()
    {
        Progresstext.text = "Puzzles 2/3";

        if (!BurningSource.isPlaying)
        {
            BurningSource.PlayOneShot(LeavesBurning);
        }
    }
}
