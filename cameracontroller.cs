using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private float sensitivity = 1f;

    private Rigidbody rb;
    private Vector3 angle;
    private Vector3 input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = Player.GetComponent<Rigidbody>();

        angle = new Vector3(-10f, 90f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
            angle += new Vector3(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X")) * sensitivity;
            angle = new Vector3(Mathf.Clamp(angle.x, -85f, 85), angle.y);

            transform.eulerAngles = new Vector3(angle.x, angle.y, 0);
    }
}
