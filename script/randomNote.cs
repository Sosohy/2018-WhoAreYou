using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomNote : MonoBehaviour {

    Transform[] points;
    public GameObject[] note;
    int[] preP;

    void Start()
    {
        points = GameObject.Find("spawnPoints").GetComponentsInChildren<Transform>();
        Debug.Log("spawn");
       
        StartCoroutine(CreateNote());
    }

    private IEnumerator CreateNote() // 코루틴
    {
        int noteCount = GameObject.FindGameObjectsWithTag("note").Length;

        int[] preP = new int[points.Length];
        int count = 0;

        while (true)
        {
            if (count <= 11)
            {
                int i = UnityEngine.Random.Range(1, points.Length);

                if(preP[i] < 1)
                {
                    Instantiate(note[count], points[i].position, points[i].rotation);
                    preP[i]++;
                    Debug.Log("생성");
                    count++;
                }
              
                
            }
            else
            {
                yield return null;
            }
        }
    }
}
