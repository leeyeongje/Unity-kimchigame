using UnityEngine;
//객체 이동 스크립트
public class Mover : MonoBehaviour
{
    [Header("Settings")] public float moveSpeed;
    void Start()
    {
        
    }
    
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
