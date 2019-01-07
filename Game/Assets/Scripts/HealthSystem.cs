using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }
public class HealthSystem : MonoBehaviour {

    public int health = 10;

    private int initialHealth;
    public float Maxhealth = 100;
    public float current;

    public UnityEvent onDie;
    public OnDamagedEvent onDamaged;


    void Start()
    {
        initialHealth = health;
    }

    public void TakeDamage( int damage)
    {

        health -= damage;

        onDamaged.Invoke(health);

            if (health < 1) {
        
            onDie.Invoke() ;
        }
    }
	
    public void ResetHealth()
    {
        health = initialHealth;
    }
}
