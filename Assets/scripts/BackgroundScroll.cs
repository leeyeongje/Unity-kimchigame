using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    [Header("Settings")]
    [Tooltip("How fast should the texture scroll?")] //스크롤스피드 설정기능에 설명 추가
    public float scrollSpeed; //스크롤 스피드 (하늘은 가장 느리게 등등) 설정 가능하게 기능추가

    [Header("References")] public MeshRenderer meshRenderer; //스크립트에 컴포넌트를 제공하는 방법
    
    void Start() //세팅값들을 설정 update가 최초로 실행되기 전 한 번만 실행
    {
        
    }
    
    void Update() //프레임 당 한번씩 실행
    {
        meshRenderer.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
    }
}
