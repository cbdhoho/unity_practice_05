using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");
        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");
        
    }
}