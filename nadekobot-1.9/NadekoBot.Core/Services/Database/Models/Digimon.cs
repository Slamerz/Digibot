namespace NadekoBot.Core.Services.Database.Models
{
    public class Digimons : DbEntity
    {
        public ulong UserId { get; set; }
        public long DigiId { get; set; }
        public string Name { get; set; }
        public Stage Stage { get; set; }
        public Type Type { get; set; }
        public Attribute Attribute { get; set; }
        public int Lvl { get; set; }
        public int Memory { get; set; }
        public int EquipSlots { get; set; }
        public int Hp { get; set; }
        public int Sp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Intelligence { get; set; }
        public int Speed { get; set; }
        public int RemainingAbi { get; set; }
        public int HpAbi { get; set; }
        public int SpAbi { get; set; }
        public int AttackAbi { get; set; }
        public int DefenseAbi { get; set; }
        public int IntelligenceAbi { get; set; }
        public int SpeedAbi { get; set; }
    }
    public enum Stage
    {
        Baby,
        InTraining,
        Rookie,
        Champion,
        Ultimate,
        Mega,
        Armor,
        None
    }
    
    public enum Type
    {
        Data,
        Free,
        Vaccine,
        Virus
    }

    public enum Attribute
    {
        Neutral,
        Earth,
        Fire,
        Plant,
        Water,
        Dark, 
        Light,
        Wind,
        Electric
    }
}
