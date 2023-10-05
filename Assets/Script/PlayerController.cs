using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    public bool gameOver = false;
    //public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>(); // Get the AudioSource component on the player
    }

    // Update is called once per frame
    void Update()
    {
        //Player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move player forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Rotates vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchSpear();
        }*/

    }

    /*private void LaunchSpear()
    {
        // Create an instance of the projectile (spear)
        GameObject spear = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        // Access the Rigidbody component of the spear
        Rigidbody rb = spear.GetComponent<Rigidbody>();

        // Get the player's forward direction (the direction they are facing)
        Vector3 launchDirection = transform.forward;

        rb.velocity = launchDirection * 90.0f;

        // Set a time delay to destroy the spear after it's launched (e.g., 5 seconds)
        float destroyDelay = 1.0f;
        Destroy(spear, destroyDelay);
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Stalker"))
        {

            gameOver = true;
            Debug.Log("Game Over!");

            playerAudio.PlayOneShot(crashSound, 1.0f);

        }

    }

}
