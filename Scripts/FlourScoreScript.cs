using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlourScoreScript : MonoBehaviour
{
    public static double FlourValue = 0;
    Text meas;
    // Start is called before the first frame update
    void Start()
    {
        meas = GetComponent<Text> ();

    }

    void Update()
    {
        meas.text = "Flour(cups): " + FlourValue;
    }
}
