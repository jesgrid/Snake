using UnityEngine.SceneManagement;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public void RestartLevel()
    {
        Debug.Log("RestartLevel");
        PlayerPrefs.SetInt("savedlevel", 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void ReloadLevel()
    {
        Debug.Log("ReloadLevel");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        Debug.Log("NextLevel");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
