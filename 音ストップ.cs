using UnityEngine;

public class 音ストップ : MonoBehaviour
{
    float limitTime;
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        limitTime = 0;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        limitTime += Time.deltaTime;
        if (limitTime >= 70)
        {
            audioSource.Stop();
        }
    }
}
