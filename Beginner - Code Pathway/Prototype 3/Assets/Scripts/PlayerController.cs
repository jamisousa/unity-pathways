using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10f;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component attached to this GameObject
        playerRb = GetComponent<Rigidbody>();

        // Modify the gravity 
        Physics.gravity *= gravityModifier;

        playerAnim = GetComponent<Animator>();

        playerAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            //add force to the Rigidbody to move the player

            //normal - applies overtime
            //impulse - applies immediately

            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false; // Player is now in the air
            playerAnim.SetTrigger("Jump_trig"); // Trigger the jump animation
            dirtParticle.Stop(); // Stop the dirt particle effect when jumping
            playerAudio.PlayOneShot(jumpSound, 1.0f); // Play jump sound effect
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player has collided with the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true; // Player is back on the ground
            dirtParticle.Play(); // Play the dirt particle effect
        }
        else if( collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over!");
            gameOver = true; // Set game over state
            playerAnim.SetBool("Death_b", true); // Trigger the death animation
            playerAnim.SetInteger("DeathType_int", 1); // Set the death type to 1
            dirtParticle.Stop();
            explosionParticle.Play(); // Play the explosion particle effect
            playerAudio.PlayOneShot(crashSound, 1.0f); // Play crash sound effect
        }
    }
}
