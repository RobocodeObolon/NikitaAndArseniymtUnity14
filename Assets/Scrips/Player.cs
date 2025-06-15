using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveV, moveH;
    public float moveSpeed = 3f;
    public Text Belly;
    public int coins;
    public GameObject Dialog;
    public GameObject Win;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(moveH, moveV) * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Belly"))
        {
            Destroy(collision.gameObject);
            coins++;
            Belly.text = ("Belly : " + coins);
        }



        if (collision.gameObject.CompareTag("Nami") && coins >= 10)
        {
            Dialog.SetActive(true);
        }
        else
        {
            Dialog.SetActive(false);
        }

    }

    public void WIN()
    {
        Win.SetActive(true);
    }

    
}
