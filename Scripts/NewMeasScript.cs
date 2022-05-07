using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewMeasScript : MonoBehaviour
{
    
    public static double measValue = 0;
    Text meas;
    // Start is called before the first frame update
    void Start()
    {
        meas = GetComponent<Text> ();

    }

    public void Increase()
    {
        measValue+=.25;
    }
    // Update is called once per frame
    void Update()
    {
        meas.text = "Sugar(cups): " + measValue;
    }
}
