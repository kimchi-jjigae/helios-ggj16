using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

    public float mRotationSpeed;
    public float mSpeedIncrement;
    float mAccumulatedRotation;
    public LevelController mLevel;

	// Use this for initialization
	void Start () {
	    mAccumulatedRotation = 0.0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(new Vector3(0, 0, mRotationSpeed));
        mAccumulatedRotation += mRotationSpeed;
        if(mAccumulatedRotation > 360.0f) {
            mLevel.LevelFinish();
        }
	}

    public void NewLevel() {
        mRotationSpeed += mSpeedIncrement;
        mAccumulatedRotation = 0.0f;
    }
}
