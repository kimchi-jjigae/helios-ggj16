using UnityEngine;
using System.Collections;

public class ObjectCollisionHandler : MonoBehaviour {

    SFXPlayer sfx;

    void Awake() {
        sfx = GameObject.Find("SFX").GetComponent<SFXPlayer>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        /*
        Health health = other.GetComponent<Health>();
        health.damage(1);
        */

        BroadcastMessage("died", gameObject, SendMessageOptions.DontRequireReceiver);
        if(gameObject.tag == "cow") {
            sfx.PlayMoo();
        }
        else if(gameObject.tag == "mountain") {
            sfx.PlayBang();
        }
        else if(gameObject.tag == "house") {
            sfx.PlayIgnite();
        }
        Destroy(gameObject);
    }
}
