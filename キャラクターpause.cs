using UnityEngine;

public class キャラクターpause : MonoBehaviour
{
    private bool isPaused = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] 会話オブジェクト = GameObject.FindGameObjectsWithTag("会話");

        if (会話オブジェクト.Length > 0)
        {
            if (!isPaused)
            {
                Pauser.Pause();
                isPaused = true;
            }
        }
        else
        {
            if (isPaused)
            {
                Pauser.Resume();
                isPaused = false;
            }
        }
    }
}
