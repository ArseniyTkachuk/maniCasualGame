using UnityEngine;

public class Usejoystick : MonoBehaviour
{
    [SerializeField] GameObject checkJoystick;
    [SerializeField] GameObject checkButton;
    private void Update()
    {
        if (PlayerPrefs.GetInt("useJoystick") == 0)
        {
            checkJoystick.SetActive(false);
            checkButton.SetActive(true);
        } else if (PlayerPrefs.GetInt("useJoystick") == 1)
        {
            checkButton.SetActive(false);
            checkJoystick.SetActive(true);
        }
    }

    public void CheckJoystick(string check)
    {
        if (check == "joystick")
        {
            PlayerPrefs.SetInt("useJoystick", 1);
        } else if (check == "button")
        {
            PlayerPrefs.SetInt("useJoystick", 0);
        }
    }
}
