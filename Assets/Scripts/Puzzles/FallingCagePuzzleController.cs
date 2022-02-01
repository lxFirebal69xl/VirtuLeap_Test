using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingCagePuzzleController : MonoBehaviour
{
    public ChainKiller firescript;
    public GameObject PuzzleCage;
    private Animator CageAnimator;
    public Text Progresstext;

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
            Progresstext.text = "Puzzles 3/3";
        }

    }
}
