using UnityEngine;
using System.Collections;

public class HeliosController : MonoBehaviour {

    Rigidbody2D mRigidbody2d;
    public float mSpeedScalar;
    Vector2 mScreenBounds;

	void Start() {
        mScreenBounds = new Vector2(10.0f, 10.0f);
        mRigidbody2d = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate() {
	    float hMovement = Input.GetAxis("Horizontal");
	    float vMovement = Input.GetAxis("Vertical");
        Vector2 force = new Vector2(hMovement * mSpeedScalar, vMovement * mSpeedScalar);
        mRigidbody2d.AddForce(force * 100.0f);
        //mRigidbody2d.velocity = force;

        /*
        float xPos = Mathf.Clamp(mRigidbody2d.position.x, -screenBounds.x, screenBounds.x);
        float yPos = Mathf.Clamp(mRigidbody2d.position.y, -screenBounds.y, screenBounds.y);
        mRigidbody2d.position = new Vector2(xPos, yPos);
        */
	}

    void Update() {
        if(Input.GetKeyDown("space")) {
            //ShootBullet();
        }
    }
}
