using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ObjectList : MonoBehaviour {
    // class filled with all the possible objects on the scene
//    public GameObject tree;
//    public GameObject tree2;
    public GameObject house;
    public GameObject house2;
    public GameObject house3;
    public GameObject house4;
    public GameObject mountain;
    public GameObject cow;
//    public GameObject rocket;
//    public GameObject maypole;
//    public GameObject flagpole;
    List<GameObject> mObjectList;

    void Start() {
        mObjectList = new List<GameObject>();
//        mObjectList.Add(tree);
//        mObjectList.Add(tree2);
        mObjectList.Add(house);
        mObjectList.Add(house2);
        mObjectList.Add(house3);
        mObjectList.Add(house4);
        mObjectList.Add(mountain);
        mObjectList.Add(cow);
//        mObjectList.Add(rocket);
//        mObjectList.Add(maypole);
//        mObjectList.Add(flagpole);
    }
    
    public GameObject ReturnRandomObject() {
        int i = Random.Range(0, mObjectList.Count);
        return mObjectList[i];
    }

}
