using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource coinSound;
   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        coinSound.Play();
        ScoreUpdate.coinCount += 1;
        gameObject.SetActive(false);
    }
}
