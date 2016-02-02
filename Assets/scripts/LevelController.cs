using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelController : MonoBehaviour {

    public Text mLivesText;
    public Text mLevelText;
    public Text mDayText;
    public Image mDaySprite;
    public Image mDaySprite2;
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
        if(mLevelNumber < 10) {
            string picpath = "numbers/n" + mLevelNumber;
            mDaySprite.sprite = Resources.Load<Sprite>(picpath);
        }
        else {
            int num1 = mLevelNumber % 10;
            int num2 = mLevelNumber / 10;
            string picpath = "numbers/n" + num1;
            mDaySprite.sprite = Resources.Load<Sprite>(picpath);
            picpath = "numbers/n" + num2;
            mDaySprite2.sprite = Resources.Load<Sprite>(picpath);

            mDaySprite2.gameObject.SetActive(true);
            mDaySprite2.gameObject.GetComponent<OpacityFader>().StartAppearing();
        }
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
