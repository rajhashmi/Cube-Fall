using UnityEngine;

public class PlayerScritps : MonoBehaviour{

    private Rigidbody2D myBody;
    public float moveSpeed = 2f;

    void Awake(){
        myBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        Move();
    }
    void Start()
    {
        
    }

    void Move(){
        if(Input.GetAxisRaw("Horizontal") > 0){
            myBody.linearVelocity = new Vector2(moveSpeed, myBody.linearVelocity.y);
        }
        if(Input.GetAxisRaw("Horizontal") < 0){
            myBody.linearVelocity = new Vector2(-moveSpeed, myBody.linearVelocity.y);
        }
    }

    public void PlatformMove(float x){
        myBody.linearVelocity = new Vector2(x, myBody.linearVelocity.y);
    }
}
