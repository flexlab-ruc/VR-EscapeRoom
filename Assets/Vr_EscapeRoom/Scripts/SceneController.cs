using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void Menu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void Lose()
    {
        SceneManager.LoadScene("Lose", LoadSceneMode.Single);
    }

    public void Win()
    {
        SceneManager.LoadScene("Win", LoadSceneMode.Single);
    }

    public void Game()
    {
        SceneManager.LoadScene("lvl-0.01", LoadSceneMode.Single);
    }

}
