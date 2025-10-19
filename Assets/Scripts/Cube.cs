using UnityEngine;

public class Cube : MonoBehaviour
{
    private InputManager inputManager;

    [SerializeField] private float MoveSpeed = 0.2f;

    private Vector3 MoveDirection;

    public enum Direction
    {
        Vertical,
        Horizontal
    }

    [Tooltip("Напрямок руху куба")]
    public Direction Dir;


    private void Awake()
    {
        inputManager = FindAnyObjectByType<InputManager>();

        if (Dir == Direction.Vertical)
        {
            MoveDirection = new Vector3(0, 0, MoveSpeed);

        }
        else if (Dir == Direction.Horizontal)
        {
            MoveDirection = new Vector3(MoveSpeed, 0, 0);
        }
    }

    private void FixedUpdate()
    {
        if (Dir == Direction.Vertical)
        {
            if (inputManager.up)
            {
                GetComponent<Rigidbody>().linearVelocity += MoveDirection;
            }

            if (inputManager.down)
            {
                GetComponent<Rigidbody>().linearVelocity -= MoveDirection;
            }
        }
        else if (Dir == Direction.Horizontal)
        {
            if (inputManager.right)
            {
                GetComponent<Rigidbody>().linearVelocity += MoveDirection;

            }

            if (inputManager.left)
            {
                GetComponent<Rigidbody>().linearVelocity -= MoveDirection;

            }
        }
    }
}
