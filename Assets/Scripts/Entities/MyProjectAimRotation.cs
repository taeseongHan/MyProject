using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyProjectAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private SpriteRenderer characterRenderer;
    [SerializeField] private Transform armPivot;

    private MyProjectCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<MyProjectCharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _controller.OnLookEvent += OnAim; 
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        armRenderer.flipY = Mathf.Abs(rotZ) > 90f;
        characterRenderer.flipX = armRenderer.flipY;
        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
