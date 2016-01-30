using UnityEngine;
using System.Collections;

public class SpawnOnDie : MonoBehaviour {

    public GameObject mPrefabToSpawn;

    void died(GameObject replacedObject)
    {
        GameObject newFire = Instantiate(mPrefabToSpawn, transform.position, transform.rotation) as GameObject;
        newFire.transform.parent = replacedObject.transform.parent;
        newFire.transform.rotation = replacedObject.transform.rotation;
        newFire.transform.localPosition = replacedObject.transform.localPosition;
    }
}
