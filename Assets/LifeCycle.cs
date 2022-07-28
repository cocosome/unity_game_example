using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    private void OnEnable() {
        Debug.Log("플레이어가 로그인했습니다.");    
    }

    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    private void FixedUpdate() {
        Debug.Log("이동~");
    }

    void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }

    private void LateUpdate() {
        Debug.Log("경험치 획득.");
    }

    private void OnDisable() {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    private void OnDestroy() {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}


//unity 생명주기
/*
    1. 초기화
    - void Awake() 최초 1회 시행
    - void Start() Update 시작전 최초 실행

    1.5 활성화
    - OnEnable() 오브젝트가 활성화 되었을때 실행되는 영역
    최초 실행이 아닌 활성화 마다 실행

    2. 물리연산
    - void FixedUpdate() 물리연산을 하기전에 실행되는 update 함수, CPU를 많이 사용

    3. 게임로직
    - void Update() 물리연산을 제외한 나머지 주기적으로 변화하는 부분에 대한 로직을 작성,
    환경에 따라 실행 주기가 달라질 수 있다.
    - void LateUpdate() 모든 업데이트가 끝난후 실행되는 부분, 카메라 및 로직후처리 등이 존재

    3.5 비활성화
    - OnDisable() 모든 오브젝트가 끝나고 비활성화 혹은 삭제될 때 실행되는 부분

    4. 해제
    - OnDestroy() 오브젝트가 삭제되기 전 무언가를 남기고 삭제된다...?


*/  