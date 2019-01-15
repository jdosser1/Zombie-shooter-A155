using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressStart : MonoBehaviour {

public void Playgame ()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Quitgame ()
    {
        Application.Quit();
    }
}
