using UnityEngine;
using UnityEngine.UI;

public class Bat : MonoBehaviour
{
    [Header("顯示訊息")]
    public Text message;
    [Header("史萊姆")]
    public Slime slime;

    private float hp = 150;
    private float atk = 50;
    private float cure = 20;

    /// <summary>
    /// 攻擊
    /// </summary>
    public void Attack()
    {
        slime.Damage(atk);
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damage"></param>
    public void Damage(float damage)
    {
        hp -= damage;
        message.text = gameObject.name + " - 受到傷害" + damage;
        message.text += "\n" + gameObject.name + " - 血量剩下：" + hp;
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
