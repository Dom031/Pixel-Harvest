using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    private AudioSource finishSound;

    private bool levelCompleted = false;

    private void Start()
    {
        finishSound = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ( collision.gameObject.name == "Player" && !levelCompleted)
        {
            finishSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 1f);
        }

    }
    private void CompleteLevel()
    {   // Getting the current scene index and adding +1 to it so it goes to the next level once 
        // checkpoint has been reached
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

 