using UnityEngine;
using System.Collections;

public class ObjectCollisionHandler : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other) {
        /*
        Health health = other.GetComponent<Health>();
        health.damage(1);
        */

        Debug.Log("KROCK BANG PANG");
        Destroy(gameObject);
    }
}
