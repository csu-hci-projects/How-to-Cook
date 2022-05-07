using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaltScoreScript : MonoBehaviour
{
    public static double SaltValue = 0;
    Text meas;
    // Start is called before the first frame update
    void Start()
    {
        meas = GetComponent<Text> ();

    }

    void Update()
    {
        meas.text = "Salt(tsp): " + SaltValue;
    }
}
