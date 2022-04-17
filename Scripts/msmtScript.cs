using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class msmtScript : MonoBehaviour
{
    private Text msmtText;

    private void Awake() {
        msmtText = transform.Find("msmtText").GetComponent<Text>();

    }

    private void Update() {
        msmtText.text = GameHandler.GetAmount().ToString();
    }
}
