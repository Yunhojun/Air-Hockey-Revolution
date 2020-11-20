using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Vector3 originPos;
    public int Speed;

    private void Start()
    {
        originPos = transform.position;
    }
    void Update()
    {
        //이동구현
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }
        //플레이어 이동제한
        if (transform.position.z < -25f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -25f);
        }
        else if (transform.position.z > 25f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 25f);
        }
        if (transform.position.y < 5f)
        {
            transform.position = new Vector3(transform.position.x, 5f, transform.position.z);
        }
        else if (transform.position.y > 45f)
        {
            transform.position = new Vector3(transform.position.x, 45f, transform.position.z);
        }
        //Hit 키 구현(예정)
        if (Input.GetKey(KeyCode.D))
        {

        }
    }
}
