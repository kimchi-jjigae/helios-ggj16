using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelController : MonoBehaviour {

    public Text mLivesText;
    public Text mLevelText;
    public Text mDayText;
    public Image mDaySprite;
    public Rotater mRotater;
    public LevelGenerator mLevelGenerator;

    int mLevelNumber;
    int mLifeAmount;

	void Start() {
        mLevelNumber = 1;
	    mLifeAmount = 0;
        Time.timeScale = 0.0f;// pauses
        mDayText.gameObject.SetActive(true);
	}
	
    public void LifeLost() {
        mLifeAmount++;
        mLivesText.text = "DESTRUCTION CAUSED: " + mLifeAmount;
    }

    public void LevelFinish() {
        mLevelNumber++;
        string num = "numbers/n" + mLevelNumber;
        mDaySprite.sprite = Resources.Load<Sprite>(num);
        mDayText.gameObject.SetActive(true);
        mDayText.gameObject.GetComponent<OpacityFader>().StartAppearing();
        mDaySprite.gameObject.SetActive(true);
        mDaySprite.gameObject.GetComponent<OpacityFader>().StartAppearing();
        mLivesText.gameObject.SetActive(false);
        mLevelText.gameObject.SetActive(false);
        mLevelText.text = "DAY: " + mLevelNumber;
        mRotater.NewLevel();
        mLevelGenerator.NewLevel();
    }

    void GameOver() {
        //
    }
}
