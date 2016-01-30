using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour {

    public int mNumberOfObstacles;
    public ObjectList mObjectList;
    public float mPlanetRadius;
    float mDegreesBetweenObjects;
    List<Vector2> mWaterIntervals;

	void Start() {
        mWaterIntervals = new List<Vector2>();

	    mDegreesBetweenObjects = 360.0f / (float)mNumberOfObstacles;
        for(int i = 0; i < mNumberOfObstacles; ++i) {
            float rotation = mDegreesBetweenObjects * i;
            if(!InWater(rotation)) {
                GameObject newObstacle = Instantiate(mObjectList.ReturnRandomObject(), transform.position, transform.rotation) as GameObject;
                newObstacle.transform.parent = transform;
                newObstacle.transform.Rotate(new Vector3(0, 0, rotation - 90));
                newObstacle.transform.localPosition = PolarToCartesian(rotation, mPlanetRadius);
            }
        }
	}
	
	void Update() {
	
	}

    Vector2 PolarToCartesian(float angleInDegrees, float length) {
        float angle = angleInDegrees * Mathf.Deg2Rad;
        float x = length * Mathf.Cos(angle);
        float y = length * Mathf.Sin(angle);

        return new Vector2(x, y);
    }

    bool InWater(float angle) {
        bool inWater = false;
        for(int i = 0; i < mWaterIntervals.Count; ++i) {
            if(angle > mWaterIntervals[i].x &&
               angle < mWaterIntervals[i].y) {
                inWater = true;
                break;
            }
        }
        return inWater;
    }
}
