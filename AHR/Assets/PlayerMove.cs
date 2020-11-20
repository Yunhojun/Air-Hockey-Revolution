using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;
    private Vector3 originPos;
    public int Speed;
    public GameObject dashEffect;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        dashTime = startDashTime;
        originPos = transform.position;
    }
    void Update()
    {
        //대시구현
        if (direction == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) && Input.GetKey(KeyCode.F))
            {
                Instantiate(dashEffect, transform.position, Quaternion.identity);
                direction = 1;
                soundManager.instance.PlaySoundDash();
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) && Input.GetKey(KeyCode.F))
            {
                Instantiate(dashEffect, transform.position, Quaternion.identity);
                direction = 2;
                soundManager.instance.PlaySoundDash();
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow) && Input.GetKey(KeyCode.F))
            {
                Instantiate(dashEffect, transform.position, Quaternion.identity);
                direction = 3;
                soundManager.instance.PlaySoundDash();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && Input.GetKey(KeyCode.F))
            {
                Instantiate(dashEffect, transform.position, Quaternion.identity);
                direction = 4;
                soundManager.instance.PlaySoundDash();
            }
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector3.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;

                if (direction == 1)
                {
                    rb.velocity = Vector3.back * dashSpeed;
                }
                else if (direction == 2)
                {
                    rb.velocity = Vector3.forward * dashSpeed;
                }
                else if (direction == 3)
                {
                    rb.velocity = Vector3.up * dashSpeed;
                }
                else if (direction == 4)
                {
                    rb.velocity = Vector3.down * dashSpeed;
                }
            }
        }
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
