using UnityEngine;

public enum CardType
{
    Robot,
    Dragon,
    Troll,
    Human,
    Elf,
    Dwarf,
    Fairy,
    Amphibian,
    Golem,
    Demon
}
public enum DamageType
{
    Chaos,
    LightMagic,
    Void,
    Ice,
    Electricity,
    Sand,
    Wind,
    Magma,
    Slashing,
    Piercing,
}
public enum DefenceType
{
    HeavyArmored,
    LightArmored,
    Unarmored,
    SkinProtection,
    MagicDefence
}
[CreateAssetMenu(fileName = "CardSO", menuName = "ScriptableObjects/CardSO")]
public class CardSO : ScriptableObject
{
    public Sprite CardImage;
    public string CardNameText;
    public string CardDescriptionText;
    public string CardTypeText;
    public CardType CardType;
    public DamageType DamageType;
    public DefenceType DefenceType;
    public int DamageAmount;
    public int HpAmount;
    public int ManaCost;
    public int GoldCost;
}
