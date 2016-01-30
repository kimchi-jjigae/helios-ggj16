using UnityEngine;
using System.Collections;

public class ObjectCollisionHandler : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other) {
        /*
        Health health = other.GetComponent<Health>();
        health.damage(1);
        */

        BroadcastMessage("died", gameObject, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject);
    }
}
