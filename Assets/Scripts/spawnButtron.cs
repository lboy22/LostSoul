using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnButtron : MonoBehaviour
{
    public GameObject thisButton;
    public int xCoord;
    public int yCoord;
    public void spawnButtonClick() {
        thisButton.transform.position = new Vector3(xCoord, yCoord, 0);
    }
}
