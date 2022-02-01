using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballThrow : MonoBehaviour
{
    public PauseMenu PauseScript;
    public GameObject projectile;
    public float projectile_speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0) && PauseScript.gameIsPaused == false)
        {
            Debug.Log("Fireball thrown");
            GameObject fireball = Instantiate(projectile, transform.position, transform.parent.rotation) as GameObject;
            Rigidbody rb = fireball.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * projectile_speed;
           // fireball.transform.parent = null;
        }

    }
}
