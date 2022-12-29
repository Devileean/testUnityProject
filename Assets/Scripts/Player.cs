using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed; // скорость передвижения
    public float jumpForce; // сила прыжка
    public Rigidbody2D rb;
    //public Transform k;
    
    private void Update()
    {
        //transform.Translate(transform.right * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))//двигаемся по вектору вперед по оси х
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);//двигаемся по вектору вперед по оси х
            //transform.Translate(transform.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))//двигаемся по вектору назад по оси х
        {
            //transform.Translate(-transform.right * speed * Time.deltaTime);
            rb.velocity = new Vector2(-speed, rb.velocity.y);//двигаемся по вектору назад по оси х
        }
        if (Input.GetKeyDown(KeyCode.Space))//добавляем прыжок
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse); //созда]м нашу силу одним импульсом
        }
    }

}