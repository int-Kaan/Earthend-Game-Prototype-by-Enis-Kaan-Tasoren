using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour
{
    [SerializeField]
    public Canvas MainMenuCanvas;
    [SerializeField]
    public Canvas OptionsMenuCanvas;
    public void PlayGame()
    {
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void GoOptionsMenu()
    {
        MainMenuCanvas.renderMode = RenderMode.WorldSpace;
        MainMenuCanvas.transform.position = new Vector2(999, 999);
        OptionsMenuCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
    }

    public void GoToMainMenuFromOptionsMenu()
    {
        MainMenuCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
        OptionsMenuCanvas.renderMode = RenderMode.WorldSpace;
        OptionsMenuCanvas.transform.position = new Vector2(999, 999);
    }
}
