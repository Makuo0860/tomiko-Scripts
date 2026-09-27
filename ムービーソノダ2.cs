using UnityEngine;

public class ムービーソノダ2 : MonoBehaviour
{
    [SerializeField] private Fade m_fade = null;
    private Animator anim;
    public float speed;
    [SerializeField] GameObject[] com;
    private bool blackOutStarted = false;
    public GameObject sonoda1;
    public GameObject sonoda2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        speed = 0.075f;
        com[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, speed);
        anim.SetBool("run", true);
        if(this.transform.position.z >= -1210 && this.transform.position.z <= -1205)
        {
            com[0].SetActive(false);
            com[1].SetActive(true);
        }
        if(this.transform.position.z >= -1185 && this.transform.position.z <= -1180)
        {
            com[1].SetActive(false);
            com[2].SetActive(true);
        }
        if(this.transform.position.z >= -1165)
        {
            com[2].SetActive(false);
            com[3].SetActive(true);
            anim.SetBool("run",false);
            blackOutStarted = true;
            m_fade.BlackOut();
            sonoda2.SetActive(true);
            sonoda1.SetActive(false);
        }
    }
}
