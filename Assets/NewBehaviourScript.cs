using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetButtonDown("Jump"))
            Debug.Log("����!");
        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��...");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!");
        
    }
}