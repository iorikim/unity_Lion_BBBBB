using UnityEngine;

namespace KID.Class9
{
    public class Dad : MonoBehaviour
    {
        public Boy boy;

        private void Start()
        {
            boy.onNoMoney += HitBoy;
            boy.onNoMoney += GiveMoney;
        }

        private void GiveMoney()
        {
            boy.money += 10;
            print("給你十塊啦 =3=");
        }

        private void HitBoy()
        {
            print("死小孩，欠揍喔!");
        }
    }
}