using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    [Header("Paddle Movement Settings")]
    [SerializeField] private float speed = 10f; // Speed of the paddle movement
    [SerializeField] private float boundary = 7.5f; // Boundary for paddle movement
    [SerializeField] private string inputAxis = "Vertical"; // Input axis for paddle movement
    [SerializeField] private KeyCode upKey; // Key for moving up
    [SerializeField] private KeyCode downKey; // Key for moving down

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
        BoundaryCheck();
    }

    private void Movement()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(upKey))
        {
            pos.y += speed * Time.deltaTime;
        }
        else if (Input.GetKey(downKey))
        {
            pos.y -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }

    private void BoundaryCheck()
    {
        if(transform.position.y > boundary)
        {
            transform.position = new Vector3(transform.position.x, boundary, transform.position.z);
        }
        else if (transform.position.y < -boundary)
        {
            transform.position = new Vector3(transform.position.x, -boundary, transform.position.z);
        }
    }
}
