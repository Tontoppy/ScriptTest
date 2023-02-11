using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100;
    private int power = 25;
    //int型の変数mpを宣言し、53で初期化してください
    private int mp = 53;
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
    //mpを消費して魔法攻撃をするMagic関数を作ってください
    /*Magic関数内でmpを5以上の場合は5減らし、
     * コンソールに 魔法攻撃をした。残りMPは〇〇。
     * と表示してください。mpが足りない場合、MPが足りないため、
     * 魔法が使えない。 と表示してください
     */
    public void Magic()
    {
        if(this.mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");

        }
    }

}
public class Test : MonoBehaviour


{

        // Start is called before the first frame update
    void Start()
    {

        //要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = { 11, 22, 33, 44, 55 };

        //for文を使い、配列の各要素の値を順番に表示してください
        for (int i = 0; i<5; i++)
        {
            Debug.Log(array[i]);

        }
        //for文を使い、配列の各要素の値を逆順に表示してください
        for (int i = 4; i >= 0 ; i--)
        {
            Debug.Log(array[i]);

        }

        Boss lastboss = new Boss ();
        lastboss.Attack();
        lastboss.Defence(3);

        /*
        Magic関数を呼び出して、魔法を使ってください
        Magic関数を10回使った後に、さらにMagic関数を呼び出すと、
        mpが足りないメッセージを表示することを確認してください
        */
        for(int i = 1; i<=11; i++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
