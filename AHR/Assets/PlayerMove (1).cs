using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int Speed;
    void Update()
    {
        //이동구현
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
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
        if (transform.position.x < -8.25f)
        {
            transform.position = new Vector3(-8.25f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 8.25f)
        {
            transform.position = new Vector3(8.25f, transform.position.y, transform.position.z);
        }
        if (transform.position.y < 1f)
        {
            transform.position = new Vector3(transform.position.x, 1f, transform.position.z);
        }
        else if (transform.position.y > 8.25f)
        {
            transform.position = new Vector3(transform.position.x, 8.25f, transform.position.z);
        }
        //Hit 키 구현(예정)
        if (Input.GetKey(KeyCode.D))
        {

        }
    }
}
