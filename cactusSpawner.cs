using UnityEngine;

public class cactusSpawner : MonoBehaviour
{
    public GameObject Cactus;
    public float spawnRate =2;
    public float timer =0;
    public float cactusSpeed =12f;
    public float heightOffset =10;
    public bool gameStarted =false;
    BeeScript bee;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     InvokeRepeating("spawnCactus", 1f, spawnRate);
     bee = FindAnyObjectByType<BeeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
       if (bee.gameStarted == false)
        {
            return;
        }
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnCactus();
                         timer =0;
        
        }
    }
    void spawnCactus()
    {
        float lowestPoint =transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        GameObject newCactus = Instantiate(Cactus, new Vector3(transform.position.x,Random.Range(lowestPoint, highestPoint),0) , transform.rotation);
        newCactus.GetComponent<cactusScript>().moveSpeed = cactusSpeed;

    }
    
}
