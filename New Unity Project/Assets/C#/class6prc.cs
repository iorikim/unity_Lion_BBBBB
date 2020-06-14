using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class class6prc : MonoBehaviour
{
    public SpriteRenderer kid;

    public Rigidbody ball;
    private void Start()
    {
        //練習1:靜態屬性
        Time.timeScale = 2;

        //練習2:非靜態屬性
        kid.flipX = true;

        //練習3:靜態方法
        print(Mathf.Floor(1.23456f));

        //4：非靜態方法
        ball.AddForce(0, 800, 1500);
    }
}
