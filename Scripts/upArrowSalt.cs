using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class upArrowSalt : MonoBehaviour
{
    private Vector2Int gridPosition;
    private Vector2Int gridPosition2;
    public UnityEvent buttonClick;


    private void Awake() {
        gridPosition = new Vector2Int(-10,-13);
        if(buttonClick == null){ buttonClick = new UnityEvent();}

    }

    private void Update() {
        
        transform.position = new Vector3(gridPosition.x, gridPosition.y);

        
    }

    public void movePlay() {
        gridPosition = new Vector2Int(11,5);
        //transform.position = new Vector4(gridPosition2.x,gridPosition2.y);

    }

    public void Increase()
    {
        SaltScoreScript.SaltValue += .25;    
    }

    void OnMouseUp(){
        buttonClick.Invoke();
    }
}
