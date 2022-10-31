using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void RestartLevel()
    {
        PlayerPrefs.SetInt("savedlevel", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
