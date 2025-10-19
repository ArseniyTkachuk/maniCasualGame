using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    [Tooltip("Джостік, компонент")]
    private Joystick Joystick;



    [SerializeField][Tooltip("Джостік, Ігровий обєкт")] private GameObject GOJoystick;
    [SerializeField] private GameObject[] ButonsController = new GameObject[4];



    [NonSerialized] public bool up, down, left, right;



    private void Awake()
    {
        Joystick = GOJoystick.GetComponent<Joystick>();


        if (PlayerPrefs.GetInt("useJoystick") == 1)
        {
            GOJoystick.SetActive(true);

            foreach (GameObject button in ButonsController)
            {
                button.SetActive(false);
            }
        }
        else
        {
            GOJoystick.SetActive(false);
            foreach (GameObject button in ButonsController)
            {
                button.SetActive(true);
            }
        }

    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("useJoystick") == 1)
            JostickController();


    }
    public void Up()
    {
        up = true;
    }

    public void Down()
    {
        down = true;
    }

    public void Right()
    {
        right = true;
    }

    public void Left()
    {
        left = true;
    }


    public void UpStop()
    {
        up = false;
    }

    public void DownStop()
    {
        down = false;
    }

    public void RightStop()
    {
        right = false;
    }

    public void LeftStop()
    {
        left = false;
    }



    private void JostickController()
    {
        if (Joystick.Horizontal >= 0.8)
            right = true;
        else
            right = false;

        if (Joystick.Horizontal <= -0.8)
            left = true;
        else
            left = false;

        if (Joystick.Vertical >= 0.8)
            up = true;
        else
            up = false;

        if (Joystick.Vertical <= -0.8)
            down = true;
        else
            down = false;
    }
}
