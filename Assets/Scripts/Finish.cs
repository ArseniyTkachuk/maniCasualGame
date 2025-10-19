using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private int LevelNum;

    private void Start()
    {
        panel.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
            PlayerPrefs.SetInt(LevelNum + "LevelIsFinish", 1);
        }
    }
}
