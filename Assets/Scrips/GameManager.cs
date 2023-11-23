using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject _GameOverCanvas;
    private void Awake()
    {
         if (instance == null) instance = this;
         Time.timeScale = 1f;
    }

    public void GameOver()
    {
        _GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
