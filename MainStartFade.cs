using UnityEngine;

public class MainStartFade : MonoBehaviour
{
    [SerializeField]
    private Fade m_fade = null;
    private bool blackOutStarted = false;

    void Start()
    {
        m_fade.BlackOut();
        blackOutStarted = true; 
        Invoke("start", 12f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void start()
    {
        blackOutStarted = false;
        m_fade.FadeIn(3.0f);
    }
}
