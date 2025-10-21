using UnityEngine;
using UnityEngine.SceneManagement; // necessário se quiser carregar cenas
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;          
    public MonoBehaviour cameraController;  
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused) Resume();
            else Pause();
        }
    }

   public void Resume()
    {
    pauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
    isPaused = false;

    if (cameraController != null)
        cameraController.enabled = true;

    Cursor.lockState = CursorLockMode.Locked; 
    Cursor.visible = false; 
    }

    public void Pause()
    {
    pauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    isPaused = true;

    if (cameraController != null)
        cameraController.enabled = false;

    Cursor.lockState = CursorLockMode.None; 
    Cursor.visible = true; 
}      
    public void QuitGame()
    {
        // Se for no editor:
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit(); // Se for buildado
        #endif
    }
}
