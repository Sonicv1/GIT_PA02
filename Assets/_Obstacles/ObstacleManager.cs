using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject Barrel;
    public GameObject Tire;
    public GameObject Ice;
    public GameObject Walrus;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnObstacle()
    {
        int RandomNumber = Random.Range(0, 3);
        Vector3 SpawnPosition = new Vector3(Random.Range(-3, 3), 0, 0);
        switch (RandomNumber)
        {
            case 0:;
                Instantiate(Barrel, SpawnPosition, Quaternion.identity);
                break;
            case 1:
                Instantiate(Tire, SpawnPosition, Quaternion.identity);
                break;
            case 2:
                Instantiate(Ice, SpawnPosition, Quaternion.identity);
                break;
            case 3:
                Instantiate(Walrus, SpawnPosition, Quaternion.identity);
                break;
        }
    }
}
