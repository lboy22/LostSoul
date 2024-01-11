using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeBuild : MonoBehaviour
{
    public float xCoord;
    public float yCoord;
    Vector3 bottomLeftCoords;
    public GameObject player;
    Vector3 topRightCoords;
    float xx;
    public GameObject thisObject;
    void Start() 
    {
        PlayerPrefs.SetInt("bridgeLeft", 0);
            PlayerPrefs.SetInt("bridgeBottom", 0);
            PlayerPrefs.SetInt("bridgeRight", 0);
            PlayerPrefs.SetInt("bridgeTop", 0);
        bottomLeftCoords = new Vector3(390, 400, 0) - new Vector3(25.0f, 20.0f, 25.0f);
        topRightCoords = new Vector3(390, 400, 0) + new Vector3(25.0f, 20.0f, 25.0f);
        print(bottomLeftCoords);
        print(topRightCoords);
    }


    bool compareVector3(Vector3 v1, Vector3 v2) 
    {
        if(v1.x > v2.x && v1.y>v2.y) {
            return true;
        }
        else {
            return false;
        }
    }
    public void onClickBridge() {
        thisObject.transform.position = new Vector3(-7.0f, 1.5f, 1.0f);
            print ("updated");
            PlayerPrefs.SetInt("bridgeLeft", -8);

            PlayerPrefs.SetInt("bridgeRight", -5);
            PlayerPrefs.SetInt("bridgeTop", 7);
    }

}
