using UnityEngine;
using System.Collections;

public class HeliosFollower : MonoBehaviour {

    public GameObject mObjectToFollow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    transform.localPosition = mObjectToFollow.transform.position;
	}
}
