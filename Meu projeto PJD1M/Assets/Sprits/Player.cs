using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
<<<<<<< HEAD
    public float velocidade = 10f;
    public float focaPulo = 10f;

    public bool noChao = false;
  

    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer  spriteRenderer; 

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    void OnCollisionStay2D(Collision2D collision)
=======
  public float velocidade = 10f;
  public float focaPulo = 10f;

    public bool noChao = false;
  

  private Rigidbody2D _rigidbody2D;
  private SpriteRenderer  spriteRenderer; 

<<<<<<< HEAD
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
=======
      public bool noChao = false;
      
      private Rigidbody2D _rigidbody2D;
      private SpriteRenderer _spriteRenderer;
      
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = 
            gameObject.GetComponent<Rigidbody2D>();
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
>>>>>>> 9950d5905244f9b63c117165ebe357412b828b91
    }


   void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            noChao = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
>>>>>>> 56bbc2e74a662a26c025204eb837dbf0d62b25e3
    {
        if (collision.gameObject.tag == "chao")
        {
            noChao = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            noChao = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if(Input.GetKey(KeyCode.LeftArrow))
=======
<<<<<<< HEAD
      if(Input.GetKey(KeyCode.LeftArrow))
      {
        gameObject.transform.position += new Vector3(-velocidade*Time.deltaTime,0,0);
        //rigidbody2D.AddForce(new Vector2(-velocidade,0));
        spriteRenderer.flipX = true;
        Debug.Log("LeftArrow");
      }
        

      if(Input.GetKey(KeyCode.RightArrow))
      {
        gameObject.transform.position += new Vector3(velocidade*Time.deltaTime,0,0);
        //rigidbody2D.AddForce(new Vector2(velocidade,0));
         spriteRenderer.flipX = false;
         Debug.Log("RightArrow");
      }

        if (Input.GetKeyDown(KeyCode.Space) && noChao == true)
        {
            _rigidbody2D.AddForce(new Vector2(0, 1) * focaPulo,ForceMode2D.Impulse);

            Debug.Log("Jump");
        }
=======
        if (Input.GetKey(KeyCode.LeftArrow))
>>>>>>> 56bbc2e74a662a26c025204eb837dbf0d62b25e3
        {
            gameObject.transform.position += new Vector3(-velocidade*Time.deltaTime,0,0);
            //rigidbody2D.AddForce(new Vector2(-velocidade,0));
            spriteRenderer.flipX = true;
            Debug.Log("LeftArrow");
        }
        

        if(Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(velocidade*Time.deltaTime,0,0);
            //rigidbody2D.AddForce(new Vector2(velocidade,0));
            spriteRenderer.flipX = false;
            Debug.Log("RightArrow");
<<<<<<< HEAD
        }

        if (Input.GetKeyDown(KeyCode.Space) && noChao == true)
        {
            _rigidbody2D.AddForce(new Vector2(0, 1) * focaPulo,ForceMode2D.Impulse);

            Debug.Log("Jump");
        }
=======
        }   
>>>>>>> 9950d5905244f9b63c117165ebe357412b828b91
>>>>>>> 56bbc2e74a662a26c025204eb837dbf0d62b25e3
    }
}