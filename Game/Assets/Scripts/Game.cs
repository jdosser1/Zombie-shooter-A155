using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour {

    public Transform[] checkPoints;
    private Transform player;

    private int currentCheckpointIndex = 0;

	void Start () {
        player = GameObject.FindWithTag("Player").transform;
        player.position = checkPoints[currentCheckpointIndex].position;
	}
	
	// Update is called once per frame
	public void OnPlayerDie ()
    {
        player.position = checkPoints[currentCheckpointIndex].position;
        player.GetComponent<HealthSystem>().ResetHealth();
        player.GetComponent<HealthSystem>().TakeDamage(0);
        Scene thisScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(thisScene.buildIndex);

    }
}
