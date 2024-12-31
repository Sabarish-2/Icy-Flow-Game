using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    //[SerializeField] private int spawnRate;
    //private int spawnTime = 0;
    //private GameObject[] collectibles;
    
    [SerializeField] private float timeBetweenWave;
    public float timePassed;
    public float totalTime;

    private void Start()
    {
        totalTime = 0;
        timePassed = 0.5f;
        timeBetweenWave = 3f;
    }


    //top = transform.GetChild(0);
    //bottom = transform.GetChild(1);
    //collectibles = new GameObject[] {  };

    [System.Serializable]
    public class Wave
    {
        public GameObject collectible;
        public int count;
        public float spawnRate;
    }

    public Wave[] waves;

    void FixedUpdate()
    {
        if (timeBetweenWave <= 0.2f)
        {
            timeBetweenWave = 0.2f;
            totalTime = 0f;
        }
        else if (((int)totalTime % 10) == 0)
        {
            timeBetweenWave -= 0.5f * Time.deltaTime;
            totalTime += Time.deltaTime;
        }
        else totalTime += Time.deltaTime;
        
        if (timePassed < 0f)
        {
            timePassed = timeBetweenWave;
            SpawnWave();
        }
        timePassed -= Time.deltaTime;
    }

    [SerializeField] private float top, bottom;
    private void SpawnWave()
    {
        //Debug.Log("Spawning wave");
        // Get a random value between 0 and the top of screen
        float randomY = Random.Range(bottom, top);
        int index = Random.Range(0, 2);
        Vector3 pos = new(transform.position.x, randomY, transform.position.z);
        Instantiate(waves[index].collectible, pos, Quaternion.identity);
    }
}