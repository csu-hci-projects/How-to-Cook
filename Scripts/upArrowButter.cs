using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class upArrowButter : MonoBehaviour
{
    private Vector2Int gridPosition;
    private Vector2Int gridPosition2;
    public UnityEvent buttonClick;


    private void Awake() {
        gridPosition = new Vector2Int(-10,-10);
        if(buttonClick == null){ buttonClick = new UnityEvent();}

    }

    private void Update() {
        
        transform.position = new Vector3(gridPosition.x, gridPosition.y);

        
    }

    public void movePlay() {
        gridPosition = new Vector2Int(13, 5);
        //transform.position = new Vector4(gridPosition2.x,gridPosition2.y);

    }

    public void Increase()
    {
        ButterScoreScript.ButterValue += .25;    
    }

    void OnMouseUp(){
        buttonClick.Invoke();
    }
}
