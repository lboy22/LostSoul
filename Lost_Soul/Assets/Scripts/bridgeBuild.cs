using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bridgeBuild : MonoBehaviour
{
    public float xCoord;
    public float yCoord;
    Vector3 bottomLeftCoords;
    Vector3 topRightCoords;
    public GameObject thisObject;
    void Start() 
    {
        
        bottomLeftCoords = new Vector3(xCoord, yCoord, 0) - new Vector3(25.0f, 10.0f, 25.0f);
        topRightCoords = new Vector3(xCoord, yCoord, 0) + new Vector3(25.0f, 10.0f, 25.0f);
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
    
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButtonDown(0) && compareVector3(Input.mousePosition, bottomLeftCoords) && compareVector3(topRightCoords, Input.mousePosition)) {
            thisObject.transform.position = new Vector3(-23.0f, 6.0f, 1.0f);
        }
    }
}
