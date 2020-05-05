﻿using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    [Header("顯示訊息")]
    public Text message;
    [Header("蝙蝠")]
    public Bat bat;

    private float hp = 200;
    private float atk = 20;
    private float cure = 10;


    public void Attack()
    {
        bat.Damage(atk);
    }

    public void Damage(float damage)
    {
        hp -= damage;
        message.text = gameObject.name + " - 受到傷害" + damage;
        message.text += "\n<color=#3F4A52>" + gameObject.name + " </color> - 血量剩下：" + hp;
    }

    /// <summary>
    /// 治癒
    /// </summary>
    public void Cure()
    {
        hp += cure;
        message.text = gameObject.name + " - 受到治癒" + cure;
        message.text += "\n" + gameObject.name + " - 血量剩下：" + hp;
    }

}
