using UnityEngine;

public class GameStartComtroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void startGame()
    {
        Time.timeScale = 1f;
    }
}
