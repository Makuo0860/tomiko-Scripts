using UnityEngine;

public class 鳥召喚 : MonoBehaviour
{
    public GameObject bird;
    private float limitTime;

    void Start()
    {
        limitTime = 0;

    }

    void Update()
    {
        limitTime += Time.deltaTime;

        if (limitTime >= 61f)
        {
            bird.SetActive(true);
        }
    }
}