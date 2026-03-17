using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Unity.VisualScripting.Dependencies;
using UnityEngine.SceneManagement;

public class BeeScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public ScoreScript score;
    public AudioSource myAudio;
    public bool beeIsAlive = true;
    public GameObject StartText;
    public bool gameStarted =false;
    public GameObject GameOverScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myAudio =GetComponent<AudioSource>();
        myRigidbody.gravityScale = 0;
    }
     
    // Update is called once per frame
    void Update()
    {
        if (beeIsAlive ==false)
        {
            return;
        }
        if (gameStarted == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameStarted = true;
                StartText.SetActive(false);
                myRigidbody.gravityScale =3;
            }
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space)  == true )
        {
             myRigidbody.linearVelocity = Vector2.up * flapStrength; 
            myAudio.Play();
        }
       
        
        }
         void OnCollisionEnter2D(Collision2D collision)
        {
            GameOverScreen.SetActive(true);
            beeIsAlive = false;
        }
       public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    }
    
