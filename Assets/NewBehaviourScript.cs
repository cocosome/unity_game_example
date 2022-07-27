using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Hello Unity!");


        //value
        int level = 5;
        float strength = 15.5f;// use f!
        string playerName = "Warrior";
        bool isFullLevel = false;

        // Debug.Log("Name?");
        // Debug.Log(playerName);
        // Debug.Log("Level?");
        // Debug.Log(level);
        // Debug.Log("Strength?");
        // Debug.Log(strength);
        // Debug.Log("Full Level?");
        // Debug.Log(isFullLevel);


        //group value
        string[] monsters = {"슬라임", "사막뱀", "악마"};

        // Debug.Log("맵에 존재하는 몬스터");
        // Debug.Log(monsters[0]);
        // Debug.Log(monsters[1]);
        // Debug.Log(monsters[2]);

        int[] monsterlevel = new int[3];
        monsterlevel[0] = 1;
        monsterlevel[1] = 6;
        monsterlevel[2] = 20;

        // Debug.Log("맵에 존재하는 몬스터의 레벨");
        // Debug.Log(monsterlevel[0]);
        // Debug.Log(monsterlevel[1]);
        // Debug.Log(monsterlevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

        // Debug.Log("가지고 있는 아이템");
        // Debug.Log(items[0]);
        // Debug.Log(items[1]);

        // items.RemoveAt(0);
        //List 0번에 있는 항목이 제거되면 1번에 있던 마나물약30이 0번으로 이동하고  List의 크기도 2에서 1로 줄어듦

        // Debug.Log("가지고 있는 아이템");
        // Debug.Log(items[0]);
        // Debug.Log(items[1]);

        int exp = 1500;
        
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp/300;
        strength = level * 3.1f;

        // Debug.Log("용사의 총 경험치는?");
        // Debug.Log(exp);
        // Debug.Log("용사의 레벨은?");
        // Debug.Log(level);
        // Debug.Log("용사의 힘은?");
        // Debug.Log(strength);

        int nextExp = 300 - (exp%300);
        // Debug.Log("다음 레벨까지 남은 경험치는?");
        // Debug.Log(nextExp);

        string title = "legend of";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

        int health = 30;
        int mana = 15;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까?" + condition);

    }

}
