using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextText : MonoBehaviour
{
    [SerializeField] GameObject[] com;
    float limitTime;
    public AudioClip sound1;
    public AudioClip sound2;
    bool sound1Played = false;
    bool sound2Played = false;

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

        if(limitTime >= 4)
        {
            com[0].SetActive(true);
        }

        if (limitTime >= 8)
        {
            com[0].SetActive(false);
            com[1].SetActive(true);
        }

        if (limitTime >= 12)
        {
            com[1].SetActive(false);
            com[2].SetActive(true);
        }

        if (limitTime >= 16)
        {
            com[2].SetActive(false);
            com[3].SetActive(true);
        }

        if (limitTime >= 20)
        {
            com[3].SetActive(false);
            com[4].SetActive(true);
        }

        if (limitTime >= 24)
        {
            com[4].SetActive(false);
        }

        if (limitTime >= 28)
        {
            com[5].SetActive(true);
        }

        if (limitTime >= 32)
        {
            com[5].SetActive(false);
            com[6].SetActive(true);
        }

        if (limitTime >= 36)
        {
            com[6].SetActive(false);
            com[7].SetActive(true);
        }

        if (limitTime >= 40)
        {
            com[7].SetActive(false);
            com[8].SetActive(true);
        }

        if (limitTime >= 44)
        {
            com[8].SetActive(false);
            com[9].SetActive(true);
        }

        if (limitTime >= 48)
        {
            com[9].SetActive(false);
            com[10].SetActive(true);
        }

        if (limitTime >= 52)
        {
            com[10].SetActive(false);
        }

        if (limitTime >= 57 && !sound1Played)
        {
            AudioSource.PlayClipAtPoint(sound1, transform.position);
            sound1Played = true;
        }

        if (limitTime >= 58 && limitTime < 60)
        {
            com[11].SetActive(true);
        }

        if (limitTime >= 60 && limitTime < 61)
        {
            com[11].SetActive(false);
            com[12].SetActive(true);
        }

        if (limitTime >= 61 && !sound2Played)
        {
            com[12].SetActive(false);
            AudioSource.PlayClipAtPoint(sound2, transform.position);
            sound2Played = true;
        }

        if (limitTime >= 62 && limitTime < 63)
        {
            com[12].SetActive(false);
            com[13].SetActive(true);
        }

        if (limitTime >= 63 && limitTime < 64)
        {
            com[13].SetActive(false);
            com[14].SetActive(true);
        }

        if (limitTime >= 64 && limitTime < 65)
        {
            com[14].SetActive(false);
            com[15].SetActive(true);
        }

        if (limitTime >= 65 && limitTime < 66)
        {
            com[15].SetActive(false);
            com[16].SetActive(true);
        }

        if (limitTime >= 66 && limitTime < 67)
        {
            com[16].SetActive(false);
            com[15].SetActive(true);
        }

        if (limitTime >= 67 && limitTime < 68)
        {
            com[15].SetActive(false);
            com[16].SetActive(true);
        }

        if (limitTime >= 68)
        {
            com[16].SetActive(false);
            com[15].SetActive(true);
        }

        if (limitTime >= 70)
        {
            com[15].SetActive(false);
        }

        if (limitTime >= 71)
        {
            SceneManager.LoadScene("ÉÅÉCÉìÉQÅ[ÉÄ");
        }
    }
}
