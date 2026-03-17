using System.Threading;
using UnityEngine;

public class cactusScript : MonoBehaviour
{
    public float moveSpeed;
    public float speedIncrease =0.5f;
    public float deadZone = -45;
    public float moveAmount = 2f;
    public float moveSpeedY = 2f;
    bool moveUpDown = false;
    ScoreScript Score;
    float Timer ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
                Score = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreScript>();

    }

    // Update is called once per frame
    void Update()
    {
       
                
        transform.position =transform.position + (Vector3.left * moveSpeed) *  Time.deltaTime;
        if (Score.PlayerScore >=50 && Score.PlayerScore <= 70)
        {
            moveUpDown = true;

        }
        else
        {
            moveUpDown =false;
        }
        if (moveUpDown)
        {
            transform.position += Vector3.up * Mathf.Sin(Time.time * moveSpeedY) * moveAmount *Time.deltaTime;
        }
        if (Score.PlayerScore >= 100)
        {
            moveSpeed =18f;
        }
   if (transform.position.x < deadZone)
        {
            Debug.Log("Cactus Deleted");
            Destroy(gameObject);
        }

    }

}
