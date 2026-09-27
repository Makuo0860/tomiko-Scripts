using UnityEngine;

public class 調べる2 : MonoBehaviour
{
    [SerializeField] GameObject[] com;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            com[0].SetActive(false);
            com[1].SetActive(true);   
        }
    }
}
