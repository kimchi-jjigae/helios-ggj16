using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PressToSkip : MonoBehaviour {

    public Text mLivesText;
    public Text mLevelText;
    public Image mDayNumber;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("space")) {
            gameObject.SetActive(false);
            mDayNumber.gameObject.SetActive(false);
            mLivesText.gameObject.SetActive(true);
            mLevelText.gameObject.SetActive(true);
            Time.timeScale = 1.0f;
        }
	
	}
}
