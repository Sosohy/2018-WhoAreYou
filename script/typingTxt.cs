using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class typingTxt : MonoBehaviour {

    public Text text;
    public Text text1;

    public Text b;
    public AudioSource typ;


    public void Start()
    {
        StartCoroutine(introStory(text));
    }

    IEnumerator introStory(Text text)
    {
        b.gameObject.SetActive(false);
        string talk = text.text;
        text.text = "";
        text.gameObject.SetActive(true);

        for (int i = 0; i < talk.Length; i++)
        {
            text.text += talk[i];

            yield return new WaitForSeconds(0.05f);
        }
        typ.mute = true;

        int count = 0;


        while (count < 3)
        {
            b.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.1f);
            b.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.1f);
            count++;
        }
        b.gameObject.SetActive(true);
    }

    public void OnClick()
    {
        text.gameObject.SetActive(false);
        b.gameObject.SetActive(false);
        text1.gameObject.SetActive(true);
    }

}
