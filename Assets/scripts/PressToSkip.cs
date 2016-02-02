using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PressToSkip : MonoBehaviour {

    public Text mLivesText;
    public Text mLevelText;
    public Image mDayNumber;

	void Start () {
	
	}
	
	void Update () {
        if(Input.anyKeyDown) {
            GetComponent<OpacityFader>().StartFading();
            mDayNumber.gameObject.GetComponent<OpacityFader>().StartFading();
            mLivesText.gameObject.SetActive(true);
            mLevelText.gameObject.SetActive(true);
            Time.timeScale = 1.0f;
        }
	
	}
}
