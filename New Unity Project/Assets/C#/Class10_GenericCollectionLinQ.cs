using UnityEngine;

namespace KID.Class10 { 
public class Class10_GenericCollectionLinQ : MonoBehaviour
{
        public CharacterFloat cF=new CharacterFloat(100.5f,50.9f,103f);   //角色浮點數
        public CharacterInt cI=new CharacterInt(100,50,15);     //角色整數

        public Character<float> c1; //使用泛型：給予浮點數
        public Character<int> c2;   //使用泛型：給予整數
        public Character<long> c3;   //使用泛型：給予整數
}
    //不使用泛型
    //假設系統需要角色類別：
    //1.浮點數欄位- 血量、經驗值、魔力、攻擊力
    //2.整數欄位 - 血量、經驗值、魔力、攻擊力
    public class CharacterFloat
    {
        public float hp;
        public float mp;
        public float exp;
        public float atk;

        public CharacterFloat(float h,float m,float a)
        {
            hp = h;
            mp = m;
            atk = a;
        }
    }

    public class CharacterInt
    {
        //多個游標：Alt + Shift + >
        public int hp;
        public int mp;
        public int exp;
        public int atk;

        //建構子：跟類別名稱相同並且無傳回的方法 - 在新增物件時執行
        public CharacterInt(int h,int m,int a)
        {
            hp = h;mp = m;atk = a;
        }

    }

    //我想多一個長整數 long

    public class Character<T>
    {
        public T hp;        //欄位的類型為泛型
        public T mp;
        public T exp;
        public T atk;
    }
}
