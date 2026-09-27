using UnityEngine;

public class 追従カメラ : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 offset;
    public float distance = 3f;
    public float mouseSpeed = 5f;

    public float minY = -30f;
    public float maxY = 60f;

    float yaw;
    float pitch;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        this.player = GameObject.Find("ソノダ").transform;
        
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void LateUpdate()
    {
        if (player == null) return;

        yaw += Input.GetAxis("Mouse X") * mouseSpeed;
        pitch -= Input.GetAxis("Mouse Y") * mouseSpeed;
        pitch = Mathf.Clamp(pitch, minY, maxY);
        distance -= Input.GetAxis("Mouse ScrollWheel") * 5f;
        distance = Mathf.Clamp(distance, 1.5f, 5f);
        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);

        Vector3 targetPos = player.position + Vector3.up * 1.5f;

        Vector3 position = targetPos - rotation * Vector3.forward * distance;
        transform.position = position;
        transform.LookAt(targetPos);
    }
}
