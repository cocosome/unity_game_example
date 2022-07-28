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
        // Debug.Log("용사의 이름은?");
        // Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        // Debug.Log("용사는 만렙입니까?" + isFullLevel);

        bool isEndTutorial = level > 10;
        // Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

        int health = 30;
        int mana = 15;
        //bool isBadCondition = health <= 50 && mana <= 20;
        bool isBadCondition = health <= 50 || mana <= 20;
        // Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";
        
        Heal(health);
        // Debug.Log("용사의 상태가 나쁩니까?" + condition);

        // if(condition == "나쁨"){
        //     Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        // }
        // else
        // {
        //     Debug.Log("플레이어 상태가 좋습니다.");
        // }

        //items.RemoveAt(0);

        // if(isBadCondition && items[0] == "생명물약30") {
        //     items.RemoveAt(0);
        //     health += 30;
        //     Debug.Log("생명포션30을 사용하였습니다.");
        // }

        // else if(isBadCondition && items[0] == "마나물약30") {
        //     items.RemoveAt(0);
        //     mana += 30;
        //     Debug.Log("마나포션30을 사용하였습니다.");
        // }

        
        // switch (monsters[0])
        // {
        //     case "슬라임" :
        //     case "사막뱀" :
        //         Debug.Log("소형 몬스터가 출현!");
        //          break;
        //     case "악마" :
        //         Debug.Log("중형 몬스터가 출현!");
        //         break;
        //     case "골렘" :
        //         Debug.Log("대형 몬스터가 출현!");
        //         break;
        //     default :
        //         Debug.Log("??? 몬스터가 출현!");
        //         break;
        // }

        // while(health > 0){
        //     health --;
        //     if(health > 0)
        //         Debug.Log("독 데미지를 입었습니다. 남은 체력: " + health);
        //     else
        //         Debug.Log("사망하였습니다.");

        //     if(health == 10){
        //         Debug.Log("해독제를 사용합니다. 남은체력: " + health);
        //         break;
        //     }
        // }

        // for(int count = 0; count<10; count++){
        //     health++;
        //     Debug.Log("붕대로 치료 중... 남은체력: "+ health);
        // }

        // for(int index = 0; index < monsters.Length; index++){
        //     Debug.Log("이 지역에 있는 몬스터 : "+ monsters[index]);
        // }

        // foreach(string monster in monsters) {
        //     Debug.Log("이 지역에 있는 몬스터(foreach) : "+ monster);
        // }

        // Debug.Log("용사의 레벨은? : "+ level);

        // for(int index = 0; index < monsters.Length; index++){
        //     Debug.Log("용사는 " + monsters[index] + "에게 " + 
        //     Battle(monsterlevel[index], level));
        // }

        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한 ";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());
        //string 함수라도 받는 변수가 없이이런식으로 써도 return값인
        //string이 출력이된다? 신기하네...
        
        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 "+player.level +" 입니다.");

        Debug.Log(player.move());
    }

    void Heal(int health)
    {
        health += 10;
        Debug.Log("힐을 받았습니다. "+ health);
    }

    string Battle(int monsterLevel, int playerlevel)
    {
        string result;
        if(playerlevel >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";
        
        return result;
    }

}
