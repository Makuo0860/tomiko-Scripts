using UnityEngine;

public class 鳥spawn : MonoBehaviour
{
    public GameObject bird1;
    public GameObject bird2;
    public GameObject bird3;
    public GameObject bird4;
    public GameObject bird5;
    public GameObject bird6;
    public GameObject bird7;
    public GameObject bird8;

    float limitTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        limitTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        limitTime += Time.deltaTime;

        if (limitTime >= 36 && limitTime <= 37)
        {
            bird1.SetActive(true);
        }

        if (limitTime >= 59 && limitTime < 60)
        {
            bird2.SetActive(true);
            bird3.SetActive(true);
            bird4.SetActive(true);
            bird5.SetActive(true);
            bird6.SetActive(true);
            bird7.SetActive(true);
            bird8.SetActive(true);
        }

    }
}
