using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;
using UnityEngine.UI;


public class GameHandler : MonoBehaviour
{

    private static GameHandler instance;

    private static double msAmount;

    private void Awake(){
        instance = this;
    }
    
    void Start()
    {
        Debug.Log("GameHandler.Start");

        GameObject cookieSpriteGameObject = new GameObject();
        SpriteRenderer cookieSpriteRenderer = cookieSpriteGameObject.AddComponent<SpriteRenderer>();
        cookieSpriteRenderer.sprite = GameAssets.i.cookieSprite; 
    }

    public static double GetAmount() {
        return msAmount;
    }

    public static void AddAmount() {
        msAmount += 0.25;
    }
}
