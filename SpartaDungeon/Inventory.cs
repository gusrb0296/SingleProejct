using static System.Console;
namespace SpartaDungeon
{
    public class Inventory
    {
        public int GearIndex {  get; set; }
        public string GearName { get; set; }
        public string GearType { get; set; }
        public int GearState { get; set; }
        public string GearInfo { get; set; }

        public string GearIsEquip = "   ";
        

        public Inventory(int index, string name, string type, int state, string info)
        {
            GearIndex = index;
            GearName = name;
            GearType = type;
            GearState = state;
            GearInfo = info;
        }        

        public void GearEquip()
        {
            GearIsEquip = "[E]";
        }

        public void GearUnEquip()
        {
            GearIsEquip = "   ";
        }

        public void Display()
        {
            WriteLine($"- {GearName} | {GearType} + {GearState} | {GearInfo}");
        }

        public void DisplayEquip()
        {
            WriteLine($"{GearIndex + 1}. {GearIsEquip} {GearName} | {GearType} + {GearState} | {GearInfo}");
        }
    }
}