using UnityEngine;

public class フラグ2 : MonoBehaviour
{
    public GameObject furag2;
    public GameObject sonoda;
    public Camera mainCamera;
    public Camera subCamera;
    public GameObject movie1;

    private bool mainCameraON;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        movie1.SetActive(false);
        mainCamera.enabled = true;
        subCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "フラグ2")
        {
            movie1.SetActive(true);
            Pauser.Pause();
            sonoda.transform.position = new Vector3(408.193f, 0.25f, -1165.023f);
            sonoda.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            furag2.SetActive(false);
            mainCamera.enabled = false;
            subCamera.enabled = true;
            mainCameraON = false;
        }
    }
}
