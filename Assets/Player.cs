using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public string PlayerName; 
    public Text PlayerText;
    public int coin = 0;
    public Text coinText;

    public void getCoin(int amount)
    {
        coin += amount;
        coinText.text = coin.ToString();
    }

    public void Start()
    {
        PlayerName = PlayerPrefs.GetString("playername");
        PlayerText.text = PlayerName;
    }


}
