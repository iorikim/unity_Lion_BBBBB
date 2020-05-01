using UnityEngine;
using UnityEngine.UI;

public class slime : MonoBehaviour
{
    /// <summary>
    /// 史萊姆的血量
    /// </summary>
    [Header("血量"), Range(0, 500)]
    public int 血量 = 150;

    /// <summary>
    /// 史萊姆的攻擊力
    /// </summary>
    [Header("攻擊力"), Range(10, 100)]
    public int 攻擊力 = 10;

    /// <summary>
    /// 史萊姆的治癒量
    /// </summary>
    [Header("治癒量"), Range(10, 100)]
    public int 治癒量 = 20;


    [Header("文字:輸出結果")]
    public Text result;
    public bat bat1;

    /// <summary>
    /// 史萊姆攻擊
    /// </summary>
    public void ATK()
    {
        result.text = bat1.name + "承受" + 攻擊力 + "點傷害";
        bat1.injured();
    }

    /// <summary>
    /// 史萊姆被攻擊
    /// </summary>
    public void injured()
    {
        int allhp = 血量 -= bat1.攻擊力;
        result.text += "\n" + gameObject.name + "當前血量:" + allhp;
    }

    /// <summary>
    /// 史萊姆回復血量
    /// </summary>
    public void Recovery()
    {
        result.text = gameObject.name + "回復" + 治癒量 + "點血量" + "\n"
            + gameObject.name + "當前血量:" + (血量 += 治癒量);


    }
}