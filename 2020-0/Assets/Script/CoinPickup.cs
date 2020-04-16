using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{

    public int coinValue;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Youve collect the coin!!");

        ScoreManager.AddPoints(coinValue);

        Destroy(gameObject);
    }
}
