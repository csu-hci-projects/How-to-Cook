using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flourScript : MonoBehaviour
{
    private Vector2Int gridPosition;
    private Vector2Int gridPosition2;


    private void Awake() {
        gridPosition = new Vector2Int(-10,-12);

    }

    private void Update() {
        
        transform.position = new Vector3(gridPosition.x, gridPosition.y);

        
    }

    public void movePlay() {
        gridPosition = new Vector2Int(12,4);
        //transform.position = new Vector4(gridPosition2.x,gridPosition2.y);

    }
}
