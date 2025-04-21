using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject GameOverPanel;
    public GameObject GameWinPanel;
    void Start()
    {
        playerMovement.enabled = true;
        GameOverPanel.SetActive(false);
        GameWinPanel.SetActive(false);
    }

    public void GameOver()
    {
        playerMovement.enabled = false;
        GameOverPanel.SetActive(true);
    }

    public void GameWin()
    {
        playerMovement.enabled = false;
        GameWinPanel.SetActive(true);
    }
    
    public void RestartGame()
    {
        var s = SceneManager.GetActiveScene();
        SceneManager.LoadScene(s.name);
    }
}
