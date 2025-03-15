using UnityEngine;
//객체 삭제 스크립트

public class Destroyer : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    { //x위치 -15보다 작으면 객체 파괴
        if (transform.position.x < -15)
        {
            Destroy(gameObject);
        }
        
    }
}
