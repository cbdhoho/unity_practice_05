using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        if (Input.GetMouseButtonDown(0)) //��Ŭ��
            Debug.Log("�̻��� �߻�!");
        if (Input.GetMouseButton(0))  //��Ŭ��
            Debug.Log("�̻��� ������ ��...");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!");

        
    }
}