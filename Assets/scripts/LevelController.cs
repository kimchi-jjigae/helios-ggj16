using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelController : MonoBehaviour {

    public Text mLivesText;
    public Text mLevelText;
    public Rotater mRotater;
    public LevelGenerator mLevelGenerator;

    int mLevelNumber;
    int mLifeAmount;

	void Start() {
        mLevelNumber = 1;
	    mLifeAmount = 5;
	}
	
    public void LifeLost() {
        if(mLifeAmount == 0) {
            GameOver();
        }
        else {
            mLifeAmount--;
            mLivesText.text = "LIVES: " + mLifeAmount;
        }
    }

    public void LevelFinish() {
        mLevelNumber++;
        mLevelText.text = "LEVEL: " + mLevelNumber;
        mRotater.NewLevel();
        mLevelGenerator.NewLevel();
    }

    void GameOver() {
        //
    }
}
