using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class talk : MonoBehaviour
{
    [SerializeField] GameObject[] com;
    float limitTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        limitTime = 0;
        for (int i = 0; i < com.Length; i++)
        {
            com[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        limitTime += Time.deltaTime;

        if (limitTime >= 2)
        {
            com[0].SetActive(true);
        }

        if (limitTime >= 6)
        {
            com[0].SetActive(false);
            com[1].SetActive(true);
        }

        if (limitTime >= 10)
        {
            com[1].SetActive(false);
            com[2].SetActive(true);
        }

        if (limitTime >= 14)
        {
            com[2].SetActive(false);
            com[3].SetActive(true);
        }

        if (limitTime >= 18)
        {
            com[3].SetActive(false);
            com[4].SetActive(true);
        }

        if (limitTime >= 22)
        {
            com[4].SetActive(false);
        }
    }
}