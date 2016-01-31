using UnityEngine;
using System.Collections;

public class RotaterSimple : MonoBehaviour {

    public float mRotationSpeed;

	void FixedUpdate () {
        transform.Rotate(new Vector3(0, 0, mRotationSpeed));
	}
}
