using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool youDied = false;

    public float delay = 0f;

    public void GameOver()
    {
        if (youDied == false)
        {
            youDied = true;
            Invoke("Restart", delay);
        }       
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
