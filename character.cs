using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public int speed;
    Animator anim;
    SpriteRenderer sr;
    void Start()
    {
        anim = this.gameObject.GetComponent<Animator>();
        sr = this.gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;                       // Sağ tuşa bastığımızda karakter X ekseninde aynalanmayacak.
            anim.SetBool("yürüme", true);          // Tuşa basıldığında Animator'a tanımladığımız "yürüme" parametresi "true" değerini alacak.
            this.gameObject.transform.position =  //Sağ tuşa tıklandığında sağa hareket
                    new Vector2(this.gameObject.transform.position.x + speed * Time.deltaTime, this.gameObject.transform.position.y);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = true;                         // Sağ tuşa bastığımızda karakter X ekseninde aynalanacak.
            anim.SetBool("yürüme", true);           // Tuşa basıldığında Animator'a tanımladığımız "yürüme" parametresi "true" değerini alacak.
            this.gameObject.transform.position =   //Sol tuşa tıklandığında sola hareket
                    new Vector2(this.gameObject.transform.position.x - speed * Time.deltaTime, this.gameObject.transform.position.y);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("yürüme", true);             // Tuşa basıldığında Animator'a tanımladığımız "yürüme" parametresi "true" değerini alacak.
            this.gameObject.transform.position =     //Yukarı tuşa tıklandığında yukarı hareket
                new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y + speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("yürüme", true);           // Tuşa basıldığında Animator'a tanımladığımız "yürüme" parametresi "true" değerini alacak.
            this.gameObject.transform.position =   //Aşağı tuşa tıklandığında aşağı hareket
                new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y - speed * Time.deltaTime);
        }
        else
        {
      
            anim.SetBool("yürüme", false);  // Hiçbir tuşa basmadığımızda Animator'a tanımladığımız "yürüme" parametresi "false" değerini alacak.
        }
    }
}
