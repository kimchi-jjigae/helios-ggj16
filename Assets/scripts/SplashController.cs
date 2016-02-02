using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour {

    public GameObject mainpic;
    public GameObject explainpic;
    bool explainOn;

	// Use this for initialization
	void Start () {
	    mainpic.SetActive(true);
	    explainpic.SetActive(false);
        explainOn = false;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.anyKeyDown) {
            if(!explainOn) {
                explainpic.SetActive(true);
                explainpic.GetComponent<OpacityFader>().StartAppearing();
                explainOn = true;
            }
            else {
                ChangeScene();
            }
        }
	
	}

    void ChangeScene() {
        Application.LoadLevel("main");
    }
}
