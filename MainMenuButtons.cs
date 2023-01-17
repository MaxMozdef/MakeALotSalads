using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void StartTheGame() => SceneManager.LoadScene(1);
    public void ExitTheGame() => Application.Quit();
}
