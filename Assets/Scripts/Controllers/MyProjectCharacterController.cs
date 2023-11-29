using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyProjectCharacterController : MonoBehaviour
{
    // event �ܺο����� ȣ������ ���ϰ� ����
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }





}

    





////�̵� ���� �ڵ�
    ////[SerializeField] private float speed = 5f;
    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    //float x = Input.GetAxisRaw("Horizontal");
    //    //float y = Input.GetAxisRaw("Vertical");

    //    //transform.position += new Vector3(x, y) * speed *Time.deltaTime;
    //}

