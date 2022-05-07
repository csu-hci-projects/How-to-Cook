using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EggScoreScript : MonoBehaviour
{
    public static double EggValue = 0;
    Text meas;
    // Start is called before the first frame update
    void Start()
    {
        meas = GetComponent<Text> ();

    }

    void Update()
    {
        meas.text = "Eggs: " + EggValue;
    }
}