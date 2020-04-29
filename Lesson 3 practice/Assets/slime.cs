using UnityEngine;

public class slime : MonoBehaviour
{
    /// <summary>
    /// 史萊姆的血量
    /// </summary>
    [Header("血量"), Range(0, 500)]
    public int HP = 150;

    /// <summary>
    /// 史萊姆的攻擊力
    /// </summary>
    [Header("攻擊力"), Range(10, 100)]
    public int ATK = 10;

    /// <summary>
    /// 史萊姆的治癒量
    /// </summary>
    [Header("治癒量"), Range(10, 100)]
    public int REC = 10;
}
