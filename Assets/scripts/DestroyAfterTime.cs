using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {

    public float seconds;
    void Start () {
        Destroy(gameObject, seconds);
    }
}

