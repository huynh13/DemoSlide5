using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaVisController : MonoBehaviour
{
    // Start is called before the first frame update
    // tương đương hàm khởi tạo 
    private Animator _animator;
    private Rigidbody2D _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        // tham chiếu  component Animator đc gắn trên nhân vật
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private int DI_BO = 3;
    private int DUNG_YEN = 1;
    private int DIE = 4;
    private int DAM = 2;

    void Update()
    {
        // khi di chuyển thì đổi animation theo hướng tương ứng 
        if (Input.GetKey(KeyCode.A)) // GetKey : hold key
        {
            
            transform.Translate(Vector3.left * 2.5f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) // GetKey : hold key
        {
            //_rigidbody.AddForce(Vector2.right * 2.5f);
            transform.Translate(Vector3.right * 2.5f * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("NHAY");
            // nhay 
            _rigidbody.AddForce(Vector2.up * 50f);
        }
        
        // bat su kien bam nut tren ban phim 
        if (Input.GetKeyDown(KeyCode.F))
        {
            _animator.SetInteger("status", DAM);
            Debug.Log("DAM");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _animator.SetInteger("status", DI_BO);
            Debug.Log("DI BO");
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            _animator.SetInteger("status", DUNG_YEN);
            Debug.Log("DUNG YEN");
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            _animator.SetInteger("status", DIE);
            Debug.Log("DIE");
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            _animator.SetInteger("status",DUNG_YEN);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        // pt duoc goi khi co va cham 
        Debug.Log(col.collider.name);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        // pt duoc goi khi cham - giu nguyen 
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        // vua thoat khoi va cham 
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        throw new NotImplementedException();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        throw new NotImplementedException();
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        throw new NotImplementedException();
    }
}