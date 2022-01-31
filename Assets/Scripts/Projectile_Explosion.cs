using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Explosion : MonoBehaviour
{

    public GameObject explosionVFX;



    void OnCollisionEnter(Collision other)
    {

        Debug.Log(other);
        Destroy(gameObject);
        Instantiate(explosionVFX, transform.position, transform.rotation);


    }


}
