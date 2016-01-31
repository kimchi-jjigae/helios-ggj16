using UnityEngine;
using System.Collections;

public class SpawnOnDie : MonoBehaviour {

    public GameObject mPrefabToSpawn;

    void died(GameObject replacedObject)
    {
        GameObject newObject = Instantiate(mPrefabToSpawn, transform.position, transform.rotation) as GameObject;
        newObject.transform.parent = replacedObject.transform.parent;
        newObject.transform.rotation = replacedObject.transform.rotation;
        newObject.transform.localPosition = replacedObject.transform.localPosition;

        if(newObject.tag == "fire") {
            newObject.transform.localPosition = ShortenPositionBy(1.0f, newObject.transform.localPosition);
        }
    }

    Vector2 ShortenPositionBy(float f, Vector2 pos) {
        float r = Mathf.Sqrt(pos.x * pos.x + pos.y * pos.y);
        float th = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
        r -= f;
        return PolarToCartesian(th, r);
    }

    Vector2 PolarToCartesian(float angleInDegrees, float length) {
        float angle = angleInDegrees * Mathf.Deg2Rad;
        float x = length * Mathf.Cos(angle);
        float y = length * Mathf.Sin(angle);

        return new Vector2(x, y);
    }
}
