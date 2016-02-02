using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OpacityFader : MonoBehaviour {

    bool fading = false;
    bool appearing = false;
    float deltaAlpha = 0.0f;
    public float fadingValue = 0.1f;
    float alphaChannel;

	void Start () {
        deltaAlpha = 0.0f;
        alphaChannel = 0.5f;
	}
	
	void FixedUpdate () {
        if(fading || appearing) {
            if(GetComponent<Image>() == null) {
                Color tmp = GetComponent<Text>().color;
                tmp.a += deltaAlpha;
                GetComponent<Text>().color = tmp;
                alphaChannel = tmp.a;
            }
            else {
                Color tmp = GetComponent<Image>().color;
                tmp.a += deltaAlpha;
                GetComponent<Image>().color = tmp;
                alphaChannel = tmp.a;
            }
        }

        if(fading && alphaChannel <= 0.0f) {
            fading = false;
            gameObject.SetActive(false);
        }
        else if(appearing && alphaChannel >= 1.0f) {
            appearing = false;
        }
	}

    public void StartFading() {
        if(GetComponent<Image>() == null) {
            Color tmp = GetComponent<Text>().color;
            tmp.a = 1.0f;
            GetComponent<Text>().color = tmp;
            alphaChannel = tmp.a;
        }
        else {
            Color tmp = GetComponent<Image>().color;
            tmp.a = 1.0f;
            GetComponent<Image>().color = tmp;
            alphaChannel = tmp.a;
        }
        fading = true;
        appearing = false;
        deltaAlpha = -fadingValue;
    }

    public void StartAppearing() {
        if(GetComponent<Image>() == null) {
            Color tmp = GetComponent<Text>().color;
            tmp.a = 0.0f;
            GetComponent<Text>().color = tmp;
            alphaChannel = tmp.a;
        }
        else {
            Color tmp = GetComponent<Image>().color;
            tmp.a = 0.0f;
            GetComponent<Image>().color = tmp;
            alphaChannel = tmp.a;
        }
        fading = false;
        appearing = true;
        deltaAlpha = +fadingValue;
    }
}
