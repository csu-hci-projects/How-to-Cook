using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gameButtonGone : MonoBehaviour
{
    GameObject button;
    public void Start() {
        button = GameObject.Find("Button");
    }

    public void ButtonClicked() {
        button.SetActive(false);   
    }
}
