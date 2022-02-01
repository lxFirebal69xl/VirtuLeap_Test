using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantBurn : MonoBehaviour
{
    public DissolveEffect dissolve;
    public AudioSource BurningSource;
    public AudioClip LeavesBurning;

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
        if (!BurningSource.isPlaying)
        {
            BurningSource.PlayOneShot(LeavesBurning);
        }
    }
}
