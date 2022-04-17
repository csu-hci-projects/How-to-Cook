using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playScript : MonoBehaviour
{
    private Vector2Int gridPosition;

    private void Awake() {
        gridPosition = new Vector2Int(-7,-3);

    }

    private void Update() {
        transform.position = new Vector3(gridPosition.x, gridPosition.y);
    }
}
