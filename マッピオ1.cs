using UnityEngine;

public class マッピオ1 : MonoBehaviour
{
    private Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("squat", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
