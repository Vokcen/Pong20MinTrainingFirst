using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Pong;
public class Ball : UIManager
{
    public Transform hand1;
    public Transform hand2;
    public Transform hand3;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] float forceValue;

    [SerializeField] Hands hand;
    int scoreLeft=0;
    int scoreRight=0;
    // Update is called once per frame
    void Start()
    {
        rigid.AddForce(transform.right * forceValue);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            rigid.AddForce(transform.forward * forceValue,ForceMode2D.Impulse);
            Debug.Log("temas");
            
        }
        if (col.gameObject.tag == "Edge")
        {
            rigid.AddForce(transform.forward * forceValue);
        }
        if (col.gameObject.tag == "EdgeDown")
        {
            rigid.AddForce(transform.forward * forceValue);
        }
        if (col.gameObject.tag == "Score1")
        {
            rigid.AddForce(transform.right * forceValue);
            hand.ball.transform.position = hand1.transform.position;
            hand.ball2.transform.position = hand2.transform.position;
            transform.position = hand3.transform.position;
            scoreLeft += 1;
            transform.position = transform.localPosition;
            _left.text = scoreLeft.ToString();

        }
        if (col.gameObject.tag == "Score2")
        {
            rigid.AddForce(-transform.right * forceValue);

            hand.ball.transform.position = hand1.transform.position;
            hand.ball2.transform.position = hand2.transform.position;
            transform.position = hand3.transform.position;

            scoreRight += 1;
            transform.position = transform.localPosition;
            _Right.text = scoreRight.ToString();
            rigid.AddForce(-transform.right * forceValue);
        }
    }
}
    

