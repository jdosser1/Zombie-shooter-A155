using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup1 : MonoBehaviour {

    HealthSystem playerHealth;
    public float healthboost = 10;

    void pickup()
    {
        playerHealth = FindObjectOfType<HealthSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if (playerHealth.current < playerHealth.Maxhealth)
        {
            Destroy(gameObject);
            playerHealth.current = playerHealth.current + healthboost;
        }
    }
}
