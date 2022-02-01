using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireCollide : MonoBehaviour
{

    public GameObject TorchLight;
    public GameObject FireFx;
    public bool Activated = false;


    void OnTriggerEnter(Collider other)
    {
       if (other.tag == "Fireball")
         {

            Debug.Log(other);
            TorchLight.SetActive(true);
            FireFx.SetActive(true);
            Activated = true;
        }



    }

}
