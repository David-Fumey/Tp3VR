using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class World : MonoBehaviour
{
    Text coinsText;
    Text alert;
    int coins = GameVariables.coins;
    GameObject canvasObj;
    Transform child;
    void Start()
    {
        canvasObj = GameObject.Find("Canvas");
        child = canvasObj.transform.Find("lblCoins");       //le	nom	de	votre	objet	UI	Text
        coinsText = child.GetComponent<Text>();
        alert = canvasObj.transform.Find("portalAlert").GetComponent<Text>();
    }

    public void AddCoin()
    {
        GameVariables.coins++;
        coinsText.text = "Coins: " + GameVariables.coins + " / " + GameVariables.maxCoins;
        if(GameVariables.coins == 6)
        {
            alert.text = "Un portail s'est ouvert !";
        }
    }
    
}
