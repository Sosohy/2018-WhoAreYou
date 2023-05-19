using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

    public float speed = 5;
    CharacterController cc;

    public float gravity = -20;

    float yVelocity; //수직 속도

    public float jumpPower = 5;  //점프속도 지정

    void Start()
    {
        cc = GetComponent<CharacterController>(); //게임오브젝트에 붙어있는 컴포넌트 가져옴       
    }

    void Update()
    {

        //사용자 입력처리
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        //카메라가 바라보는 방향으로 변형
        dir = Camera.main.transform.TransformDirection(dir);

        //만약 사용자가 JUMP 버튼을 클릭하면
        if (Input.GetButtonDown("Jump"))
        {
                yVelocity = jumpPower; //점프적용
        }
        
        //중력적용
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * speed * Time.deltaTime);
    }
}
