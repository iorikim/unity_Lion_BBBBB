using UnityEngine;

public class Fly : Monster
{
    [Header("飛行範圍"), Range(1, 30)]
    public float range;

    /// <summary>
    /// 飛行
    /// </summary>
    private void FlyAway()
    {
        transform.Translate(0, range*Time.deltaTime*Mathf.Sin(Time.timeSinceLevelLoad*5), 0);
    }

    protected override void Update()
    {
        base.Update();          //保留父類別內容
        FlyAway();

    }
}
