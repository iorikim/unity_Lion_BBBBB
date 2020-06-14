using UnityEngine;         //引用  unity API (函式庫 : unity 屬性、功能。。。)

//類別 class 定義一個物件
//語法:class 類別名稱
//: MonoBehaviour 可以將此腳本掛在 Unity 物件上
// 類別必須放在物件上才會執行
public class class1: MonoBehaviour
{
    // 定義類別成員
    // C#
    // 1.大小不一樣
    // 2.括號成對出現 () [] {} ' ' "" < >
    /// <summary>
    /// 學習模式
    /// </summary>
    [Header("汽車1號")]
    public Car car1;

    [Header("汽車2號")]
    public Car car2;

    // 事件:在特定時間會以指定次數執行的方法 (名稱為藍色)
    //開始事件:撥放遊戲時執行一次-初始設定
    private void Start()
    {
       //輸出("文字訊息");
       // C# 結尾為分號 ;
        print("哈囉，沃德~");

        //取得 get
        print("汽車1號的CC數"+car1.cc);
        print("汽車2號的品牌"+car2.brand);
        print("汽車2號的剎車開關" + car2.brake);
        //設定 set
        car1.cc = 9999;
        car1.weight = 999.9f;
        car1.brand = "TOYOTA";
        car1.brake = true;



    }
}
