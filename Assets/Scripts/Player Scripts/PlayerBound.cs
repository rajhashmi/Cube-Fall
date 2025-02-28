using UnityEngine;

public class PlayerBound : MonoBehaviour{
    public float minX = -2.6f, maxX = 2.6f, minY = -5.6f;

    private bool outOfBounds;

    void Update(){
        CheckBounds();
    }

    void CheckBounds(){
        Vector2 temp = transform.position;

        if(temp.x > maxX){
            temp.x = maxX;
        }
        if(temp.x < minX){
            temp.x = minX;
        }
        transform.position = temp;
        if(temp.y <= minX){
            if(!outOfBounds){
                outOfBounds = true;
                SoundManager.instance.DeathSound();
                GameManager.instance.RestartGame();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D target){
        if(target.tag == "TopSpike"){
            transform.position = new Vector2(1000f, 1000f);
            SoundManager.instance.DeathSound();
            GameManager.instance.RestartGame();
        }
    }
}
