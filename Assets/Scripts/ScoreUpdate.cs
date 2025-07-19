using UnityEngine;
using TMPro;
using System.Collections;

public class ScoreUpdate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public static int coinCount = 0;
    public GameObject coinDisplay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinDisplay.GetComponent<TMPro.TMP_Text>().text = "COINS: " + coinCount;
    }

    
}
