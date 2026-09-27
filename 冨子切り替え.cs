using UnityEngine;

public class 冨子切り替え : MonoBehaviour
{
    public GameObject tomiko1;
    public GameObject tomiko2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tomiko2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x >= 680)
        {
            tomiko1.SetActive(false);
            tomiko2.SetActive(true);
        }
    }
}
