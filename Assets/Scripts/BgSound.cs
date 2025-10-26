using UnityEngine;
using UnityEngine.UI;

public class BgSound : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] private Slider slider;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        if (!PlayerPrefs.HasKey("volume"))
            PlayerPrefs.SetFloat("volume", 1f);
        if (slider != null)
            slider.value = PlayerPrefs.GetFloat("volume");
    }

    private void Update()
    {
        audioSource.volume = PlayerPrefs.GetFloat("volume");
    }

    public void SetVolume(float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);
    }
}
