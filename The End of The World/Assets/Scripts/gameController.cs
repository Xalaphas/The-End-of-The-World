using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public int totalScore;

    public static gameController instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

}
