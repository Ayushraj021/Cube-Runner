using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript plyscript;
    public Score score;
    public GameController gameController;
    public AudioSource audioSource;
    public AudioSource audioSource1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Destroy(other.gameObject);
            score.AddScore(1);
            audioSource.Play();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            plyscript.enabled = false;
            gameController.gameOver();
            audioSource1.Play();
        } 
    }
}
