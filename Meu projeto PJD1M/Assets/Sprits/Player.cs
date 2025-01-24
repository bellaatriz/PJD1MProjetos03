using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 10f;
    public float focapulo = 10f;

      public bool noChao = false;
      
      private Rigidbody2D _rigidbody2D;
      private SpriteRenderer _spriteRenderer;
      
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = 
            gameObject.GetComponent<Rigidbody2D>();
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            noChao = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);
            //rigidbody2D.AddForce(nem Vector2(-velocidade,0));
            _spriteRenderer.flipX = true;
            Debug.Log("LeftArrow");
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);
            //rigidbody2D.AddForce(nem Vector2(velocidade,0));
            _spriteRenderer.flipX = false;
            Debug.Log("RightArrow");
        }   
    }
}
