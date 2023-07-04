
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    [SerializeField] GameObject tallObstaclePrefab;
    [SerializeField] float tallObstaclechance=0.2f;

    // Start is called before the first frame update
    void Start()
    {
        groundSpawner= GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
        SpawnCoins();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        GameObject obstacleToSpawn=obstaclePrefab;
        float random=Random.Range(0f,1f);
        if(random<tallObstaclechance)
        {
            obstacleToSpawn=tallObstaclePrefab;
        }
        //choose a random point to spawn the obstacle
        int obstacleSpawnIndex=Random.Range(2,5);
        Transform spawnPoint=transform.GetChild(obstacleSpawnIndex).transform;

        //Spawn the obstacle at the point 
        Instantiate(obstacleToSpawn,spawnPoint.position,Quaternion.identity,transform);
    }

    [SerializeField] GameObject coinPrefab;

    void SpawnCoins()
    {
        int coinsToSpawn=5;
        for(int i=0;i<coinsToSpawn;i++)
        {
            GameObject temp=Instantiate(coinPrefab,transform);
            temp.transform.position=GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point= new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
            if(point!=collider.ClosestPoint(point))
            {
                point=GetRandomPointInCollider(collider);
            }

            point.y=1;
            return point;
    }
}
