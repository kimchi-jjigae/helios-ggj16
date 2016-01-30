﻿using UnityEngine;
using System.Collections;

public class HeliosController : MonoBehaviour {

    Rigidbody2D mRigidbody2d;
    public float mForceScalar;
    public float mGravityFactor;

    // position offset stuff //
    float mLimitX = 0.1f;
    float mLimitY = 0.3f;
    float mTimeFactorX = 1.3f;
    float mTimeFactorY = 2.0f;
    Vector2 mPositionBeforeOffset;

    //Vector2 mPositionBounds;

	void Start() {
        //mScreenBounds = new Vector2(10.0f, 10.0f);
        mRigidbody2d = GetComponent<Rigidbody2D>();

        mPositionBeforeOffset = mRigidbody2d.position;
	}
	
	void FixedUpdate() {
        // player input force //
        mRigidbody2d.position = mPositionBeforeOffset;
	    float hMovement = Input.GetAxis("Horizontal");
	    float vMovement = Input.GetAxis("Vertical");
        Vector2 force = new Vector2(hMovement, vMovement);
        mRigidbody2d.AddForce(force * mForceScalar);

        // manual gravity //
        Vector2 gravity = new Vector2(0.0f, -mGravityFactor);
        mRigidbody2d.AddForce(gravity);
        mPositionBeforeOffset = mRigidbody2d.position;

        // positional offset //
        float offsetX = mLimitX * Mathf.Sin(Time.time * mTimeFactorX);
        float offsetY = mLimitY * Mathf.Cos(Time.time * mTimeFactorY);
        Vector2 positionOffset = new Vector2(offsetX, offsetY);
        mRigidbody2d.position += positionOffset;

        /*
        float xPos = Mathf.Clamp(mRigidbody2d.position.x, -mPositionBounds.x, mPositionBounds.x);
        float yPos = Mathf.Clamp(mRigidbody2d.position.y, -mPositionBounds.y, mPositionBounds.y);
        mRigidbody2d.position = new Vector2(xPos, yPos);
        */
	}

    void Update() {
        if(Input.GetKeyDown("space")) {
            //ShootBullet();
        }
    }
}
