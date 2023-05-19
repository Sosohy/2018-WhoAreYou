using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class citizen : MonoBehaviour {

   
    public GameObject GetGameObject;


    void OnMouseUp()
    {

        Debug.Log("클릭");
        Destroy(obj:GetGameObject);
        Debug.Log("범인이 아닙니다! ");
        player.HP -= 30;
        sapple.SHP -= 1;
        mapple.MHP -= 1;
        lapple.lHP -= 1;
        Debug.Log("현재 플레이어의 체력은" + player.HP + "입니다 ");
    }
}
