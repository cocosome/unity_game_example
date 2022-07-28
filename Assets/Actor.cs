public class Actor
{
    public int id;
    public string name;
    public string title;
    public string weapon;
    public float strength;
    public int level;

    public string Talk()
    {
        return "대화를 걸었습니다.";
    }

    public string HasWeapon()
    {
        return weapon;
    }

    public void LevelUp()
    {
        level = level + 1;
    }
}

//class 가 public이라고 해서 그 안의 내용까지 모두 public인건 아니다
//기본적으로 안의 내용은 private이므로 이를 public으로 바꿔줘야 다른 class에서 접근이 가능하다.
