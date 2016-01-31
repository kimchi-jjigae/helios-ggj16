using UnityEngine;
using System.Collections;

public class HeliosController : MonoBehaviour {

    Rigidbody2D mRigidbody2d;
    public float mPlayerForceScalarX;
    public float mPlayerForceScalarY;
    public float mGravityFactor;

    // position offset stuff //
    public float mHoverLimitX;
    public float mHoverLimitY;
    public float mHoverTimeX;
    public float mHoverTimeY;
    Vector2 mPositionBeforeOffset;

    // position nerfing //
    public Vector2 mPositionBoundsBL;
    public Vector2 mPositionBoundsTR;
    public float mNerfingFactor;

	void Start() {
        mRigidbody2d = GetComponent<Rigidbody2D>();

        mPositionBeforeOffset = mRigidbody2d.position;

        mPositionBoundsBL = new Vector2(-2.0f, 17.0f);
        mPositionBoundsTR = new Vector2(4.0f, 25.0f);
	}
	
	void FixedUpdate() {
        // player input force //
        mRigidbody2d.position = mPositionBeforeOffset;
	    float hMovement = Input.GetAxis("Horizontal");
	    float vMovement = Input.GetAxis("Vertical");
        Vector2 force = new Vector2(hMovement * mPlayerForceScalarX, vMovement * mPlayerForceScalarY);
        mRigidbody2d.AddForce(force);

        // manual gravity //
        Vector2 gravity = new Vector2(0.0f, -mGravityFactor);
        mRigidbody2d.AddForce(gravity);

        // position nerfer //
        Vector2 nerfer = new Vector2(0.0f, 0.0f);
        if(transform.position.x < mPositionBoundsBL.x) {
            nerfer.x = +mNerfingFactor;
        }
        else if(transform.position.x > mPositionBoundsTR.x) {
            nerfer.x = -mNerfingFactor;
        }
        if(transform.position.y < mPositionBoundsBL.y) {
            nerfer.y = +mNerfingFactor;
        }
        else if(transform.position.y > mPositionBoundsTR.y) {
            nerfer.y = -mNerfingFactor;
        }
        mRigidbody2d.AddForce(nerfer);

        // positional offset //
        mPositionBeforeOffset = mRigidbody2d.position;
        float offsetX = mHoverLimitX * Mathf.Sin(Time.time * mHoverTimeX);
        float offsetY = mHoverLimitY * Mathf.Cos(Time.time * mHoverTimeY);
        Vector2 positionOffset = new Vector2(offsetX, offsetY);
        mRigidbody2d.position += positionOffset;
	}
}
