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
        if (v1.x > v2.x && v1.y > v2.y)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //xx = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 1.0f)).x;
        //print("mouse position is " + Input.mousePosition);
        //if(xx < -5.0f && Input.GetMouseButtonDown(0)) {
        //    thisObject.transform.position = new Vector3(-23.0f, 6.0f, 1.0f);
        //}
        //&& compareVector3(Camera.main.ScreenToWorldPoint(Input.mousePosition), bottomLeftCoords) && compareVector3(Camera.main.ScreenToWorldPoint(topRightCoords), Input.mousePosition)
        if (Input.GetMouseButtonDown(0) && compareVector3(Input.mousePosition, bottomLeftCoords) && compareVector3(topRightCoords, Input.mousePosition))
        {
            thisObject.transform.position = new Vector3(-7.0f, 1.5f, 1.0f);
            print("updated");
            PlayerPrefs.SetInt("bridgeLeft", -8);

            PlayerPrefs.SetInt("bridgeRight", -5);
            PlayerPrefs.SetInt("bridgeTop", 7);
        }
    }
}
