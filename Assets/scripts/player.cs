using UnityEngine;

public class player : MonoBehaviour
{
    [Header("Settings")] public float JumpForce;

    [Header("References")] 
	public Rigidbody2D PlayerRigidBody;
	public Animator PlayerAnimator;

    private bool isGrounded = true;
    
    void Start()
    {
        
    }

    void Update() //유저가 스페이스 키를 누르는 것을 감지하는 작업
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            PlayerRigidBody.AddForceY(JumpForce, ForceMode2D.Impulse);
            isGrounded = false;
			PlayerAnimator.SetInteger("state", 1); //점프 상태 애니메이션 적용을 위한 작업
        }
    }

    void OnCollisionEnter2D(Collision2D collision) //플레이어와 플렛폼이 충돌했을때 실행되는 함수 
    {
        if (collision.gameObject.name == "platform")
        {
			if(!isGrounded)
			{
				PlayerAnimator.SetInteger("state",2);
			}
            isGrounded = true;
        }
    }
}
