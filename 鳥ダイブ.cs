using UnityEngine;

public class 鳥ダイブ : MonoBehaviour
{
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = -0.08f;
    }

    // Update is called once per frame 1.35 候補
    void Update()
    {
        transform.Translate(0, speed, 0);

        if (this.transform.position.y <= 1.4)
        {
            speed = 0;
        }
    }
}
