using UnityEngine;
using System.Collections;

public class BushController : MonoBehaviour {
	void Start () {
        float angle = Random.value * 360.0f;
        float radius = Random.value * 3.0f + 13.0f;
        transform.localPosition = PolarToCartesian(angle, radius);
	    
        transform.Rotate(new Vector3(0, 0, angle + 90.0f));
	
	}

    Vector2 PolarToCartesian(float angleInDegrees, float length) {
        float angle = angleInDegrees * Mathf.Deg2Rad;
        float x = length * Mathf.Cos(angle);
        float y = length * Mathf.Sin(angle);

        return new Vector2(x, y);
    }
}
