using UnityEngine;

public class Fadein : MonoBehaviour
{
    [SerializeField] private Fade m_fade = null;

    private float limitTime;
    private bool blackOutStarted = false;

    private void Start()
    {
        limitTime = 0f;

        // 最初は5秒かけてフェードイン
        m_fade.FadeIn(5.0f);
    }

    private void Update()
    {
        limitTime += Time.deltaTime;

        if (limitTime >= 70.0f && !blackOutStarted)
        {
            blackOutStarted = true;

            // 一瞬で黒画面
            m_fade.BlackOut();
        }
    }
}