using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScreenController : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }



   public void RestartGame()
    {
        SceneManager.LoadScene(0);


    }


    public void ExitGame()
    {

        Application.Quit();
    }
}
