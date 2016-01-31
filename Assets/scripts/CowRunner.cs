using UnityEngine;
using System.Collections;

public class CowRunner : MonoBehaviour {

    public float mRunSpeed;
    float mRunAccumulator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float x = transform.localPosition.x;
        float y = transform.localPosition.y;
        float r = Mathf.Sqrt(x * x + y * y);
        float th = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
        th += mRunSpeed;
        transform.localPosition = PolarToCartesian(th, r);
        transform.Rotate(new Vector3(0, 0, mRunSpeed));
        mRunAccumulator+= mRunSpeed;
        if(mRunAccumulator > 30.0f) {
            Destroy(gameObject);
        }
	}

    Vector2 PolarToCartesian(float angleInDegrees, float length) {
        float angle = angleInDegrees * Mathf.Deg2Rad;
        float x = length * Mathf.Cos(angle);
        float y = length * Mathf.Sin(angle);

        return new Vector2(x, y);
    }
}
