using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour {

    private void OnMouseUp()
    {
        SceneManager.LoadScene("", LoadSceneMode.Single);
    }
}
