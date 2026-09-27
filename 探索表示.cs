using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 探索表示 : MonoBehaviour
{
    private float distance;

    public GameObject sonoda;
    public GameObject hyouji;

    void Start()
    {
        sonoda = GameObject.FindGameObjectWithTag("ソノダ");
    }

    void Update()
    {
        distance = Vector3.Distance(
            this.transform.position,
            sonoda.transform.position);

        if (distance >= 2.25f)
        {
            hyouji.SetActive(false);
        }
        else if (distance <= 2.0f)
        {
            hyouji.SetActive(true);
        }

        GameObject[] 会話オブジェクト = GameObject.FindGameObjectsWithTag("会話");

        if (会話オブジェクト.Length > 0)
        {
            hyouji.SetActive(false) ;
        }
    }
}