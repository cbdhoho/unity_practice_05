using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    private void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }
    private void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    private void FixedUpdate()
    { 
        Debug.Log("�̵�~");
    }

    private void Update()
    {
        Debug.Log("���� ���!!");
    }

    private void LateUpdate()
    {
        Debug.Log("����ġ ȹ��.");
    }

    private void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }

    private void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� ��ü�Ͽ����ϴ�.");
    }

    
}