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

    }

    
    private void OnCollisionEnter(Collision collision)//if player collides with stalker is game over
    {
        if (collision.gameObject.CompareTag("Stalker"))
        {

            gameOver = true;
            Debug.Log("Game Over!");

            playerAudio.PlayOneShot(crashSound, 1.0f);

        }

    }

}
