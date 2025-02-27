using UnityEngine;

public class PlatformSpawner : MonoBehaviour{

    public GameObject platform_Prefab;
    public GameObject spikePlaformPrefab;
    public GameObject[] movingPlatformPrefab;
    public GameObject breakablePlatformPrefab;

    public float platform_Spawn_Timer = 2f;
    private float current_Platform_Spawn_Timer;

    private int platform_Spawn_Count;

    public float min_X = -2f, max_X = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
