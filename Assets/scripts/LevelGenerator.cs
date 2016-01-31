using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelGenerator : MonoBehaviour {

    public int mNumberOfObstacles;
    public ObjectList mObjectList;
    public float mPlanetRadius;
    float mDegreesBetweenObjects;
    List<Vector2> mWaterIntervals;
    List<GameObject> mPrefabs;

	void Start() {
        mWaterIntervals = new List<Vector2>();
        mWaterIntervals.Add(new Vector2( 35.0f,  50.0f));
        mWaterIntervals.Add(new Vector2(101.0f, 128.0f));
        mWaterIntervals.Add(new Vector2(170.0f, 176.0f));
        mWaterIntervals.Add(new Vector2(243.0f, 250.0f));
        mWaterIntervals.Add(new Vector2(262.0f, 273.0f));
        mWaterIntervals.Add(new Vector2(322.0f, 337.0f));
        mPrefabs = new List<GameObject>();
        SpawnNewLevel();
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

    bool RandomlyEliminated() {
        return Random.Range(0, 20) < 16;
    }

    public void NewLevel() {
        SpawnNewLevel();
    }

    void SpawnNewLevel() {
        // clear first prefabs
        mPrefabs.Clear();
	    mDegreesBetweenObjects = 360.0f / (float)mNumberOfObstacles;
        for(int i = 0; i < mNumberOfObstacles; ++i) {
            float rotation = mDegreesBetweenObjects * i;
            if(!InWater(rotation) && !RandomlyEliminated()) {
                GameObject newObstacle = Instantiate(mObjectList.ReturnRandomObject(), transform.position, transform.rotation) as GameObject;
                float offset = 0.0f;
                if(newObstacle.tag == "cow") {
                    offset = 1.2f;
                }
                float length = mPlanetRadius - offset;
                newObstacle.transform.parent = transform;
                newObstacle.transform.Rotate(new Vector3(0, 0, rotation - 90));
                newObstacle.transform.localPosition = PolarToCartesian(rotation, length);
                mPrefabs.Add(newObstacle);
            }
        }
    }
}
