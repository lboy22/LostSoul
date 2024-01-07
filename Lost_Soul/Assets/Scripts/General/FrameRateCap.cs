using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRateCap : MonoBehaviour
{
    private enum limits
    {
        thirtyCap = 30, sixtCap = 60
    }

    [SerializeField] limits cap;
    // Start is called before the first frame update
    void Awake()
    {
        Application.targetFrameRate = (int)cap;
    }
}
