using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camRotate : MonoBehaviour {

    public float mouseSpeed = 100;

    //각도 누적 변수
    float mx;
    float my;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;//마우스 커서 고정
    }

  

    void Update()
    {
        Cursor.visible = true;


        //마우스 입력처리
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        //동기화를 시키기 위해 Time.deltaTime을 반드시 곱해준다.
        mx += x * mouseSpeed * Time.deltaTime;
        my += y * mouseSpeed * Time.deltaTime;

        //각도를 -90 ~ 90 사이로 제한
        my = Mathf.Clamp(my, -90, 90);

        transform.eulerAngles = new Vector3(-my, mx, 0);
    }

    }
