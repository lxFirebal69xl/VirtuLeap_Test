using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveEffect : MonoBehaviour {

    Material mat;
    public float lerpSpeed = 0.3f;
    private float timer;
    public bool oneShot = true;

    private void Start() {
        mat = GetComponent<Renderer>().material;
       
        if (oneShot) { 
        AutoDestruct();
        }
    }

    IEnumerator AutoDestruct()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

    private void Update() {



        timer = Mathf.Clamp01(timer + Time.deltaTime * lerpSpeed);

        mat.SetFloat("_DissolveAmount", Mathf.Lerp(1, 0, timer));



    }

}