using UnityEngine;
using System.Collections;

public class CloudController : MonoBehaviour {
    float mRunSpeed;

	// Use this for initialization
	void Start () {
        mRunSpeed = Random.value * 0.2f + 0.01f;
        float angle = Random.value * 360.0f;
        float radius = Random.value * 5.5f + 17.0f;
        transform.localPosition = PolarToCartesian(angle, radius);
	    
        transform.Rotate(new Vector3(0, 0, angle + 90.0f));
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
	}

    Vector2 PolarToCartesian(float angleInDegrees, float length) {
        float angle = angleInDegrees * Mathf.Deg2Rad;
        float x = length * Mathf.Cos(angle);
        float y = length * Mathf.Sin(angle);

        return new Vector2(x, y);
    }
}
