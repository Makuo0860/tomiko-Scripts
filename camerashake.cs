using UnityEngine;

public class camerashake : MonoBehaviour
{
    public float strength = 0.05f;

    private Vector3 startPos;

    private float limitTime;
    private bool shakeStarted;

    void Start()
    {
        startPos = transform.localPosition;

        limitTime = 0f;
        shakeStarted = false;
    }

    void Update()
    {
        limitTime += Time.deltaTime;

        if (limitTime >= 57.5f)
        {
            shakeStarted = true;
        }

        if (shakeStarted)
        {
            transform.localPosition =
                startPos + Random.insideUnitSphere * strength;
        }
        else
        {
            transform.localPosition = startPos;
        }
    }
}