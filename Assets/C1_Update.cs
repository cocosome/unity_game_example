using UnityEngine;

public class C1_Update : MonoBehaviour
{
    void Update()
    {  
        //Input : 게임 내 입력을 관리하는 클래스
        //anyKeyDown : 아무 입력을 "최초"로 받을 때 true
        if(Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        //anyKey = 아무 입력을 받으면 true
        // if(Input.anyKey)
        //     Debug.Log("플레이어가 아무 키를 누르고 있습니다");

        
        //입력함수는 keydown, keystay, keyup등으로 키보드를 눌렀을 때, 누르고 있을때, 손을 뗐을때3가지로 구분함

        /*
            GetKeyDown = 키보드를 눌렀을 때 발동(true)
            GetKey = 키보드를 누르는 중에 발동(true)
            GetKeyUp = 키보드에서 손을 뗐을 떄 발동(true)
        */

        /*
            KeyCode.something = 실제 키보드의 something을 입력받았을 때를 의미

            -----example-----
            KeyCode.Return = enter키
            KeyCode.LeftArrow = 방향키 왼쪽
            KeyCode.RightArrow = 방향키 오른쪽
            KeyCode.a = a키
            KeyCode.F1 = F1키
            KeyCode.Escape = ESC키
        */

        // if(Input.GetKeyDown(KeyCode.Return))
        //     Debug.Log("아이템을 구입하였습니다.");
        
        // if(Input.GetKey(KeyCode.LeftArrow))
        //     Debug.Log("왼쪽으로 이동 중");

        // if(Input.GetKeyUp(KeyCode.RightArrow))
        //     Debug.Log("오른쪽 이동을 멈추었습니다.");


        /*
            GetMouseButtonDown = 마우스 버튼을 눌렀을 때 발동(true)
            GetMouseButton = 마우스 버튼을 누르는 중에 발동(true)
            GetMousButtonUp = 마우스 버튼에서 손을 뗐을 때 발동(true)

            GetMouseButton(0) - 왼쪽 마우스 버튼
            GetMouseButton(1) - 오른쪽 마우스 버튼
        */

        if(Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");

        if(Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if(Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");

        /*
            Project Settings - Input Manager에 등록된 key를 통해서 입력을 받을 수 있다.

            Input Manager의 size를 늘리면 사용자 설정 button을 추가할 수 있다.

            같은 이름으로 여러 hardware device를 동시에 발동 가능하다!
            

            GetButtonDown("something") = something을 눌렀을 때 발동
            GetButton("something") = something을 누르는 중에 발동
            GetButtonUp("something") = something에서 손을 땠을 때 발동

            "Jump" = spacebar를 의미함
            "vertical" = w, s, 키보드 위키, 키보드 아래키 모두 반응함

        */
        
        if(Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if(Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");
        
        if(Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");
        

        if(Input.GetButtonDown("Vertical"))
            Debug.Log("상하키를 눌렀습니다.");

        /*
            GetAxis = 수평, 수직을 입력받고 float를 반환(float)
            - 키보드를 눌렀을 때 누르는 정도에 따른 가중치를 반환함

            GetAxisRaw = 수평, 수직을 입력받고 int를 반환(int)
            - GetAxis와 달리 가중치값이 나오지 않고 0과 1같이 정수형태로 값이 출력
        */  


        if(Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal"));
        }

        if(Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));
        }

        
    }
}
