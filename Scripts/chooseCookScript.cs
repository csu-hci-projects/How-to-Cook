using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseCookScript : MonoBehaviour
{
    private Vector2Int gridPosition;
    private Vector2Int gridPosition2;


    private void Awake() {
        gridPosition = new Vector2Int(-7,3);

    }

    private void Update() {
        
        transform.position = new Vector3(gridPosition.x, gridPosition.y);

        
    }

    public void movePlay() {
        gridPosition = new Vector2Int(3, 3);
        //transform.position = new Vector4(gridPosition2.x,gridPosition2.y);

    }

    public void moveAway() {
        gridPosition = new Vector2Int(-7, 2);
        //transform.position = new Vector4(gridPosition2.x,gridPosition2.y);

    }
}
