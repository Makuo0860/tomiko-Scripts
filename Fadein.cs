using UnityEngine;

public class Fadein : MonoBehaviour
{
    [SerializeField] private Fade m_fade = null;

    private float limitTime;
    private bool blackOutStarted = false;

    private void Start()
    {
        limitTime = 0f;

        m_fade.FadeIn(5.0f);
    }

    private void Update()
    {
        limitTime += Time.deltaTime;

        if (limitTime >= 70.0f && !blackOutStarted)
        {
            blackOutStarted = true;

            m_fade.BlackOut();
        }
    }
}