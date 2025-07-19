using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 200.0f;
    private float horizontalSpeed;
    public ParticleSystem explosionParticle;
    private float verticalSpeed;
    public float leftLimit = -7.0f;
    public float rightLimit = 5.0f;
    

    // Update is called once per frame
    void Update()
    {
        horizontalSpeed = Input.GetAxis("Horizontal");
        // verticalSpeed = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed );
        if((this.gameObject.transform.position.z > leftLimit) && (gameObject.transform.position.x < 22.43))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalSpeed);
        }
        
        if(this.gameObject.transform.position.z < rightLimit && gameObject.transform.position.x < 22.8)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalSpeed);
        }

    }
}
