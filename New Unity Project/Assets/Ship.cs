using UnityEngine;

public class Ship : MonoBehaviour
{
    //公開欄位:給任何人存取
    //從其他類別取得或存放資料
    public float speed = 20;

    //私人欄位:僅限於此類別存取
    //從其他類別無法取得或存放資料
    private float weight = 50;

    //問題:
    //假設需要取得但是不能修改 - 屬性 (權限)
    //屬性語法
    //修飾詞 類型 名稱 {存取權限}
    //get 可以取得
    //set 可以存放
    //讀寫權限屬性
    //屬性不會顯示在屬性面板上 (ODIN) - UnityEdior
    public float length { get; set; }

    //企劃：寬度固定 30 不變
    //封裝欄位
    //1. 私人欄位
    //2. 唯讀欄位 (return 私人欄位)
    public float _width =30;
    //唯讀屬性
    public float width { get { return _width; } }

    //企劃：寬度固定10.5不變
    private float _height = 10.5f;

    // => (黏巴達 Lambda)
    // c# 6版以上 | unity 2017 c# 7 版
    //c# 改版 8 版
    //get => _height; 等同於 get { return _height}
    //=>直接把 {return}取代掉的簡易寫法
    //public float height  { get => _height; set =>_height = value; }
    public float height { get => _height; }

    private float lv = 3;
    //企劃:攻擊力等於 攻擊力 * 等級
    //封裝欄位:
    //1. 私人欄位
    //2. 透過屬性存取(return 私人欄位)(私人欄位 = value)
    // value 設定屬性時給予的值
    private float _atk;
    public float atk { get { return _atk; }set { _atk = value * lv; } }
}
