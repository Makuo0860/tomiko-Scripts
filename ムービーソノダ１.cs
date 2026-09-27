using UnityEngine;

public class ムービーソノダ１ : MonoBehaviour
{
    public float speed;
    public float rotate;

    private Animator anim;

    public GameObject sonoda1;
    public GameObject sonoda2;
    public Camera subCamera;
    public Camera subCamera2;

    public GameObject tomiko;
    public GameObject tomiko2;
    public GameObject tomiko3;
    public GameObject tomiko4;

    [SerializeField] GameObject[] com;

    private bool mainCameraON;
    private bool firstStart = true;
    private bool rotating = false;

    void Start()
    {
        speed = 0.05f;
        rotate = 3f;

        anim = GetComponent<Animator>();

        transform.rotation = Quaternion.Euler(0f, 180f, 0f);

        subCamera.enabled = true;
        subCamera2.enabled = false;

        mainCameraON = true;

        tomiko.SetActive(true);
        tomiko2.SetActive(false);
        tomiko3.SetActive(false);
        tomiko4.SetActive(false);
        sonoda2.SetActive(false);
    }

    void Update()
    {
        if (firstStart)
        {
            first();
        }

        if (rotating)
        {
            RotateSonoda();
        }
    }

    void first()
    {
        transform.Translate(0f, 0f, speed);
        anim.SetBool("walk", true);
        if (transform.position.z <= -1221.199f)
        {
            speed = 0f;
            anim.SetBool("walk", false);
            firstStart = false;
            rotating = true;
            com[0].SetActive(true);
        }
    }

    void RotateSonoda()
    {
        transform.Rotate(0f, rotate, 0f);
        if (transform.eulerAngles.y >= 270f)
        {
            transform.rotation = Quaternion.Euler(0f, 270f, 0f);
            rotating = false;
            Invoke("zoom", 5f);
        }
    }

    void zoom()
    {
        com[0].SetActive(false);

        subCamera.enabled = false;
        subCamera2.enabled = true;

        mainCameraON = false;

        tomiko.SetActive(false);
        tomiko2.SetActive(true);

        Invoke("chase1", 3f);
    }

    void chase1()
    {
        subCamera.enabled = true;
        subCamera2.enabled = false;

        mainCameraON = true;

        com[1].SetActive(true);
        tomiko2.SetActive(false);
        tomiko3.SetActive(true);

        Invoke("chase2", 2f);
    }

    void chase2()
    {
        com[1].SetActive(false);
        com[2].SetActive(true);
        Invoke("chase3", 2f);
    }

    void chase3()
    {
        com[2].SetActive(false);
        sonoda2.SetActive(true);
        sonoda1.SetActive(false);
    }
}