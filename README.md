# SingleProejct

## 구현한 내용
1. 인벤토리 클래스 구현, 생성자와 매서드 구현을 했습니다.
2. 인벤토리를 List에 넣어 배열화 한 뒤 생성자로 객체를 생성했습니다.
```cs
 public static List<Inventory> InvenGears = new List<Inventory>();
 private static int inputKey;
 static void Main(string[] args)
 {
     Inventory gear0 = new Inventory(0, "천 옷", "방어력", 2, "평상시에 입는 옷이다." );
     Inventory gear1 = new Inventory(1, "녹슨 검", "공격력", 5, "흔하게 볼 수 있는 검이다." );

     InvenGears.Add(gear0);
     InvenGears.Add(gear1);
```

3. 장비에 해당하는 번호를 누르면 `[E]`가 표시되며 메서드를 이용해 출력했습니다.
```cs
static void DisplayEquipControl(List<Inventory> gear)
{

    Clear();
    WriteLine("인벤토리 - 장착관리");
    WriteLine("장비의 번호를 입력하면 아이템을 장착, 해제 할 수 있습니다.");
    WriteLine("");
    WriteLine("[아이템 목록]");
    gear[0].DisplayEquip();
    gear[1].DisplayEquip();
    WriteLine("");
    WriteLine("");
    WriteLine("0. 나가기");

    inputKey = CheckInputKey(0, 2);
    switch (inputKey)
    {
        case 1:
            if(InvenGears[inputKey-1].GearIsEquip != "[E]")
                InvenGears[inputKey-1].GearEquip();
            else
                InvenGears[inputKey-1].GearUnEquip();
            DisplayEquipControl(InvenGears);
            break;

        case 2:
            if (InvenGears[inputKey - 1].GearIsEquip != "[E]")
                InvenGears[inputKey - 1].GearEquip();
            else
                InvenGears[inputKey - 1].GearUnEquip();
            DisplayEquipControl(InvenGears);
            break;

        case 0:
            DisplayInventory();
            break;
    }
}
```
 
4. 장착상태 `[E]`라면 스탯에 해당 장비가 가진 스탯의 추가치가 반영되고 스탯보기에서 볼 수 있습니다.
```cs
static void DisPlayMyState(List<Inventory> gear)
{
    Clear();

    int atk = 0;
    int armor = 0;

    for(int i = 0; i < gear.Count; i++)
    {
        if(gear[i].GearType == "공격력" && gear[i].GearIsEquip == "[E]")
        {
            atk += gear[i].GearState;
        }
        else if (gear[i].GearType == "방어력" && gear[i].GearIsEquip == "[E]")
        {
            armor += gear[i].GearState; 
        }
    }

    WriteLine();
    WriteLine("상태보기");
    WriteLine("캐릭터의 정보가 표시됩니다.");
    WriteLine();
    WriteLine($"Lv.{player.Level}");
    WriteLine($"{player.Name}({player.Job})");            
    WriteLine($"공격력 :{player.Atk} + {atk}");
    WriteLine($"방어력 : {player.Def} + {armor}");

    WriteLine($"체력 : {player.Hp}");
    WriteLine($"Gold : {player.Gold} G");
    WriteLine();
    WriteLine("1. 나가기");

    inputKey = CheckInputKey(1, 1);
    switch(inputKey)
    {
        case 1:                        
            MainTitle();
            break;
    }
}
```


