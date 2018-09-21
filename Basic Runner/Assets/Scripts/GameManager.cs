using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameEnded = false;

    public float restartDelay = 1f;

    public void EndGame()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
            // Restart Game
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
