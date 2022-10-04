using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 _direction;
    private CharacterController _Chara;
    public float _movespeed = 20f;
    private float gravityValue = -9.81f;
    private float _JumpHeight = 1f;
    void Awake()
    {
        _Chara = GetComponent<CharacterController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _Chara.Move(move.z * Time.deltaTime * _movespeed * transform.forward);
        _Chara.Move(move.x * Time.deltaTime * _movespeed * transform.right);
        
           // gameObject.transform.forward = move;

       // _direction.z += gravityValue * Time.deltaTime;
       // _Chara.Move(_direction * Time.deltaTime);
    }
}
