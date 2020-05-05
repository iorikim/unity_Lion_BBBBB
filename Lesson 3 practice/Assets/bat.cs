using UnityEngine;
using UnityEngine.UI;

public class bat : MonoBehaviour
{
    /// <summary>
    /// 蝙蝠的血量
    /// </summary>
    [Header("血量"), Range(0, 500)]
    public int 血量 = 240;

    /// <summary>
    /// 蝙蝠的攻擊力
    /// </summary>
    [Header("攻擊力"), Range(10, 100)]
    public int 攻擊力 = 30;

    /// <summary>
    /// 蝙蝠的治癒量
    /// </summary>
    [Header("治癒量"), Range(10, 100)]
    public int 治癒量 = 10;

    [Header("文字:輸出結果")]
    public Text result;
    public slime slime1;

    /// <summary>
    /// 蝙蝠攻擊
    /// </summary>
    public void ATK()
    {
        result.text = slime1.name + "承受" + 攻擊力 + "點傷害";
        slime1.injured();
    }

    /// <summary>
    /// 蝙蝠被攻擊
    /// </summary>
    public void injured()
    {
        int allhp = 血量 -= slime1.攻擊力;
         result.text += "\n" +  gameObject.name + "當前血量:" + allhp;
    }

    /// <summary>
    /// 蝙蝠回復血量
    /// </summary>
    public void Recovery()
    {
        result.text = gameObject.name + "回復" + 治癒量 + "點血量" + "\n"
            + gameObject.name + "當前血量:" + (血量 += 治癒量);
    }
}
