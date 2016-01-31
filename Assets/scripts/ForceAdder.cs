using UnityEngine;
using System.Collections;

public class ForceAdder : MonoBehaviour {

    Rigidbody2D mRigidbody2d;
    public float mPlayerForceScalarX;
    public float mPlayerForceScalarY;
    public float mSideGravity;
    public float mGravityFactor;

	void Start () {
        mRigidbody2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    float hMovement = Input.GetAxis("Horizontal");
	    float vMovement = Input.GetAxis("Vertical");
        Vector2 force = new Vector2(-hMovement * mPlayerForceScalarX, -vMovement * mPlayerForceScalarY);
        mRigidbody2d.AddForce(force);

        Vector2 gravity = new Vector2(-mSideGravity, -mGravityFactor);
        mRigidbody2d.AddForce(gravity);
	}
}
