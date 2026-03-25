using UnityEngine;

public sealed class GameManager
{
    public void FinishGame()
    {
        Time.timeScale = 0f;
        Debug.Log("Game Finished");
    }
}
