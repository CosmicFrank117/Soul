using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{
    public GameObject gameOverCanvas;

    private void Start()
    {
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void HandleDeath()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
