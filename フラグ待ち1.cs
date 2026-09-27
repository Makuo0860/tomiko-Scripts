using UnityEngine;

public class フラグ待ち1 : MonoBehaviour
{
    [SerializeField] GameObject[] com;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "フラグ待ち1")
        {
            com[0].SetActive(true);
        }
        if (other.gameObject.tag == "フラグ待ち2")
        {
            com[1].SetActive(true);
        }
        if(other.gameObject.tag == "stop")
        {
            com[2].SetActive(true);
        }
    }
}
