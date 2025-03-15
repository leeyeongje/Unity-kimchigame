using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Settings")]
    public float minSpawnDelay;
    public float maxSpawnDelay;
    
    
    
    [Header("References")] public GameObject[] gameObjects;
    void Start()
    {
        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay)); //메소드를 min~max 사이에서 랜덤으로 호출
    }

    void Spawn() //5가지의 빌딩 중 랜덤으로 스폰하는 로직 생성
    {
        GameObject randomObject = gameObjects[Random.Range(0, gameObjects.Length)];
        Instantiate(randomObject, transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
