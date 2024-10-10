using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    //int variable to store coin count
    public int coins = 0;
    //TMP_Text variable stores the text to be changed
    public TMP_Text coinCount;

    //OnTriggerEnter is called when two game objects collide
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Specifically, looking for collisions with objects tagged "coin"
        if(other.gameObject.CompareTag("Coin"))
        {
            //the coin will be destroyed
            Destroy(other.gameObject);
            //the coin count is incremented
            coins++;
            //and the text displayed is updated
            coinCount.text = "Coins: " + coins.ToString();
        }
    }
}
