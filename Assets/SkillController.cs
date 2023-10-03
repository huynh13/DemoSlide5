using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SkillController : MonoBehaviour
{
    // Start is called before the first frame update
    // 1 biến là vector : quy định hướng di chuyển 
    public Vector3 direction = Vector3.right;
    public float speed = 10f;

    private Rigidbody2D _rigidbody;
    // 1 hàm, di chuyển cho skill
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        // van toc 
        _rigidbody.velocity = new Vector2(speed,0f);
    }
    // Update is called once per frame
    void Update()
    {
        //transform.Translate(direction * speed * Time.deltaTime);
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // in ra ten cua gameObject bi skill cham vao !!!!
        Debug.Log(col.collider.gameObject.name);
        if (col.collider.gameObject.name == "deep_0")
        {
            // nhan vat bi skill thi bien mat!!!
            Destroy(col.collider.gameObject);
            // skill cung bien mat
            Destroy(gameObject);
        }
    }
}
