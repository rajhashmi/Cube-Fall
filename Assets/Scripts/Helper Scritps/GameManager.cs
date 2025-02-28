using UnityEngine;

public class GameManager : MonoBehaviour{

    public static GameManager instance;

    public bool gameOver;

    void Awake(){
        if(instance == null){
            instance = this;
        }
    }

   public void RestartGame(){
        Invoke("RestartAfterTime", 2f);
    }

    void RestartAfterTime(){
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
   }

}
