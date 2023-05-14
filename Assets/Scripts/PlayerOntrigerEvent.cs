using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Numerics;
using Vector3 = UnityEngine.Vector3;

public class PlayerOntrigerEvent : MonoBehaviour
{
    
    [SerializeField] int coins = 0;
    [SerializeField] AudioSource CoinBip;
    [SerializeField] GameObject Finishpanel;
    [SerializeField] GameObject Player;
    public TMP_Text CoinValue;
    void Start()
    {
        CoinValue.text = "0";
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            
            Destroy(collision.gameObject);
            ADDCoins();
        }
        if (collision.CompareTag("Finish"))
        {
            Debug.Log("Finish!");
            Finishpanel.SetActive(true);
        }
        if (collision.CompareTag("Die"))
        {
            Debug.Log("Die");
            Player.transform.position = new Vector3(2.29f, 0, 0);



        }

    }

    void ADDCoins()
    {
        
        coins++;
            Debug.Log(coins);
            CoinValueset(coins);
        
    }

   
    void CoinValueset(int X)
    {
        string value = X.ToString();
        CoinValue.text =  value;
    }

    


}
