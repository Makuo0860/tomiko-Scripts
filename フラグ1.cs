using UnityEngine;

public class フラグ1 : MonoBehaviour
{
    public GameObject furag1;
    public AudioClip sound;
    [SerializeField] GameObject[] com;
    public GameObject stop;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stop.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "フラグ1")
        {
            AudioSource.PlayClipAtPoint(sound,transform.position);
            stop.SetActive(true);
            Invoke("talk2",1f);
            furag1.SetActive(false);
        }
    }

    void talk2()
    {
        com[0].SetActive(true);
        Invoke("talk3", 4f);
    }

    void talk3()
    {
        com[1].SetActive(true);
        com[0].SetActive(false);
        Invoke("talk4", 4f);
    }

    void talk4()
    {
        com[1].SetActive(false);
    }

}
