using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCharcherScript : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1.0f;
    }

    public void ResetGame()
    {
        PlayerPrefs.DeleteAll();
    }

    public void CharchScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PauseOn(GameObject panel)
    {
        Time.timeScale = 0f;
        panel.SetActive(true);
    }

    public void PauseOof(GameObject panel)
    {
        Time.timeScale = 1.0f;
        panel.SetActive(false);
    }


}
