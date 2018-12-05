using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCloser : MonoBehaviour {

    public Transform door;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other) {
        door.gameObject.SetActive(true);
	}
}
