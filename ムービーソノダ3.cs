using UnityEngine;

public class ムービーソノダ3 : MonoBehaviour
{
    [SerializeField] GameObject[] com;
    [SerializeField] private Fade m_fade = null;
    private bool blackOutStarted = false;
    private Animator anim;
    public Camera subCamera;
    public Camera mainCamera;
    private bool mainCameraON;
    public GameObject sonoda1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("squat", true);
        com[0].SetActive(true);
        mainCameraON = true;
        subCamera.enabled = true;
        mainCamera.enabled = false;
        Invoke("movie1", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        if (com[7].activeSelf && Input.GetMouseButtonDown(0))
        {
            com[8].SetActive(true);
            com[7].SetActive(false);

            Invoke("movie8", 4f);
        }
    }

    void movie1()
    {
        com[0].SetActive(false);
        com[1].SetActive(true);
        blackOutStarted = false;
        m_fade.FadeIn(5.0f);
        Invoke("movie2", 7f);
    }

    void movie2()
    {
        com[1].SetActive(false);
        com[2].SetActive(true);
        m_fade.FadeOut(4.0f);
        Invoke("movie3", 4f);
    }

    void movie3()
    {
        com[2].SetActive(false);
        Invoke("movie4", 4f);
    }

    void movie4()
    {
        m_fade.FadeIn(4.0f);
        com[3].SetActive(true);
        Invoke("movie5", 4f);
    }

    void movie5()
    {
        com[3].SetActive(false);
        com[4].SetActive(true);
        Invoke("movie6", 4f);
    }

    void movie6()
    {
        com[4].SetActive(false);
        com[5].SetActive(true);
        Invoke("movie7", 4f);
    }
    
    void movie7()
    {
        com[5].SetActive(false);
        com[6].SetActive(true);
        Invoke("movieex", 4f);
    }

    void movieex()
    {
        com[6].SetActive(false);
        com[7].SetActive(true);
    }

    void movie8()
    {
        com[8].SetActive(false);
        com[9].SetActive(true);
        Invoke("movie9", 4f);
    }

    void movie9()
    {
        com[9].SetActive(false);
        com[10].SetActive(true);
        Invoke("movie10", 4f);
    }

    void movie10()
    {
        com[10].SetActive(false);
        com[11].SetActive(true);
        Invoke("movie11", 4f);
    }

    void movie11()
    {
        com[11].SetActive(false);
        com[12].SetActive(true);
        Invoke("movie12", 4f);
    }

    void movie12()
    {
        com[12].SetActive(false);
        com[13].SetActive(true);
        Invoke("movie13", 4f);
    }

    void movie13()
    {
        com[13].SetActive(false);
        com[14].SetActive(true);
        Invoke("movie14", 4f);
    }

    void movie14()
    {
        com[14].SetActive(false);
        com[15].SetActive(true);
        Invoke("movie15", 4f);
    }

    void movie15()
    {
        com[15].SetActive(false);
        com[16].SetActive(true);
        Invoke("movie16", 4f);
    }

    void movie16()
    {
        com[16].SetActive(false);
        com[17].SetActive(true);
        Invoke("movie17", 4f);
    }
    void movie17()
    {
        com[17].SetActive(false);
        com[18].SetActive(true);
        Invoke("movie18", 4f);
    }

    void movie18()
    {
        com[18].SetActive(false);
        mainCameraON = false;
        subCamera.enabled = false;
        mainCamera.enabled = true;
        sonoda1.SetActive(false);
    }
}
