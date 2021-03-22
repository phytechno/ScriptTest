using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int hp = 100;
    int mp = 53;
    int power = 25;

    //攻撃用の関数
    public void Attack(){
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage){
        Debug.Log(damage+"のダメージを受けた");
        //残りHPを減らす
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic(){
        if(mp>5){
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは"+mp);
        }
        else{
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}
public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //課題用array配列の初期化
        int[] array = {2,3,5,7,11};
        int i = 0;

        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //array配列を順番に表示
        for(i=0;i<5;i++){
            Debug.Log(array[i]);
        }

        i = 0;
        //array配列を逆順に表示
        for(i=4;i>=0;i--){
            Debug.Log(array[i]);
        }

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //魔法攻撃用の関数を11回呼び出す
        i = 0;
        for(i=0;i<11;i++){
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}