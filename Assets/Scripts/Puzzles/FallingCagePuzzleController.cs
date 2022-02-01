using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCagePuzzleController : MonoBehaviour
{
    public ChainKiller firescript;
    public GameObject PuzzleCage;
    private Animator CageAnimator;

    // Start is called before the first frame update
    void Start()
    {
        CageAnimator = PuzzleCage.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (firescript.Activated)
        {

            CageAnimator.SetTrigger("Cage_Fall");

        }

    }
}
