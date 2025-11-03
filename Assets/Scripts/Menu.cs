using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void OnVectorButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnScalarButton()
    {
        SceneManager.LoadScene(2);
    }

    public void OnDotButton()
    {
        SceneManager.LoadScene(3);
    }

    public void onQuitButtion()
    {
        Application.Quit();
    }
}
