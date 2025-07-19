using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class CollisionDetector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    public GameObject playerAnim;
    public AudioSource collisionSound;
    public ParticleSystem explosionParticle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        collisionSound.Play();
        player.GetComponent<PlayerController>().enabled = false;
        playerAnim.GetComponent<Animator>().Play("Stumble Backwards 1");
        explosionParticle.Stop();
        StartCoroutine(MainMenu());
    }

    IEnumerator MainMenu()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}

