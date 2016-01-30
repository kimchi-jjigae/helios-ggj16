using UnityEngine;
using System.Collections;

public class ForceAdder : MonoBehaviour {

    Rigidbody2D mRigidbody2d;
    public float mForceScalarX;
    public float mForceScalarY;

	void Start () {
        mRigidbody2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	    float hMovement = Input.GetAxis("Horizontal");
	    float vMovement = Input.GetAxis("Vertical");
        Vector2 force = new Vector2(-hMovement * mForceScalarX, vMovement * mForceScalarY);
        mRigidbody2d.AddForce(force);
	}
}
