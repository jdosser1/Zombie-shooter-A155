using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour {

    public Transform[] checkPoints2;
    private Transform player;

    private int currentCheckpointIndex = 0;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        player.position = checkPoints2[currentCheckpointIndex].position;
    }

    // Update is called once per frame
    public void OnPlayerDie()
    {
        player.position = checkPoints2[currentCheckpointIndex].position;
        player.GetComponent<HealthSystem>().ResetHealth();
        player.GetComponent<HealthSystem>().TakeDamage(0);
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.buildIndex);

    }
}
