using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControls : MonoBehaviour
{

    [SerializeField] private string NameScene;
    public void ButtonStartPressed()
    {
        SceneManager.LoadScene(NameScene);
    }

    public void ButtonExitPressed()
    {
        Debug.Log("Exit pressed!");
        Application.Quit();
    }
}
