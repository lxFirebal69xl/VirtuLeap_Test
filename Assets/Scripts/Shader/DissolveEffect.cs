using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveEffect : MonoBehaviour {

    Material mat;
    public float lerpSpeed = 0.3f;
    private float timer;
    public bool activate = false;
    public GameObject Plant;


    private void Start() {
        mat = GetComponent<Renderer>().material;
       
      
    }

    IEnumerator AutoDestruct()
    {
        yield return new WaitForSeconds(3);
        Destroy(Plant);
    }

    private void Update() {

        if (activate) {

        StartCoroutine("AutoDestruct");

        timer = Mathf.Clamp01(timer + Time.deltaTime * lerpSpeed);

        mat.SetFloat("_DissolveAmount", Mathf.Lerp(0, 1, timer));
           
        }


    }

}