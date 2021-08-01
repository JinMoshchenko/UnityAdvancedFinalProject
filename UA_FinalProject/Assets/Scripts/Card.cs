using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Card : MonoBehaviour
{
    public CardSO cardSO;

    Sprite damageTypeImage;
    Sprite defenceTypeImage;
    CardType cardType;
    DamageType damageType;
    DefenceType defenceType;

    private void OnEnable()
    {
        CardInit();
    }

    public void CardInit()
    {
        if (cardSO != null)
        {
            switch (cardSO.DamageType)
            {
                case DamageType.Chaos:
                    damageTypeImage = Resources.Load<Sprite>("Sprites/DamageTypeSprites/Chaos");
                    break;
                case DamageType.Electricity:
                    damageTypeImage = Resources.Load<Sprite>("Sprites/DamageTypeSprites/Electricity");
                    break;
                case DamageType.Ice:
                    damageTypeImage = Resources.Load<Sprite>("Sprites/DamageTypeSprites/Ice");
                    break;
                case DamageType.LightMagic:
                    damageTypeImage = Resources.Load<Sprite>("Sprites/DamageTypeSprites/LightMagic");
                    break;
                case DamageType.Magma:
                    damageTypeImage = Resources.Load<Sprite>("Sprites/DamageTypeSprites/Magma");
                    break;
                case DamageType.Piercing:
                    damageTypeImage = Resources.Load<Sprite>("Sprites/DamageTypeSprites/Piercing");
                    break;
                case DamageType.Sand:
                    damageTypeImage = Resources.Load<Sprite>("Sprites/DamageTypeSprites/Sand");
                    break;
                case DamageType.Slashing:
                    damageTypeImage = Resources.Load<Sprite>("Sprites/DamageTypeSprites/Slashing");
                    break;
                case DamageType.Void:
                    damageTypeImage = Resources.Load<Sprite>("Sprites/DamageTypeSprites/Void");
                    break;
                case DamageType.Wind:
                    damageTypeImage = Resources.Load<Sprite>("Sprites/DamageTypeSprites/Wind");
                    break;
                default:
                    Debug.Log("It's default");
                    break;
            }
            switch (cardSO.DefenceType)
            {
                case DefenceType.HeavyArmored:
                    defenceTypeImage = Resources.Load<Sprite>("Sprites/DefenceTypeSprites/HeavyArmored");
                    break;
                case DefenceType.LightArmored:
                    defenceTypeImage = Resources.Load<Sprite>("Sprites/DefenceTypeSprites/LightArmored");
                    break;
                case DefenceType.MagicDefence:
                    defenceTypeImage = Resources.Load<Sprite>("Sprites/DefenceTypeSprites/MagicDefence");
                    break;
                case DefenceType.SkinProtection:
                    defenceTypeImage = Resources.Load<Sprite>("Sprites/DefenceTypeSprites/SkinProtection");
                    break;
                case DefenceType.Unarmored:
                    defenceTypeImage = Resources.Load<Sprite>("Sprites/DefenceTypeSprites/Unarmored");
                    break;
                default:
                    Debug.Log("It's default");
                    break;
            }

            // Card pic
            transform.Find("background/forground/cardPicBackground/cardPicForground/cardPic").gameObject.GetComponent<Image>().sprite = cardSO.CardImage;
            // Damage type pic
            transform.Find("background/forground/damageTypeBackground/damageTypeForground/damageTypePic").gameObject.GetComponent<Image>().sprite = damageTypeImage;
            // Defense type pic
            transform.Find("background/forground/defenceTypeBackground/defenceTypeForground/defenceTypePic").gameObject.GetComponent<Image>().sprite = defenceTypeImage;
            // Card name
            transform.Find("background/forground/cardNameBackground/cardNameText").gameObject.GetComponent<TextMeshProUGUI>().SetText(cardSO.CardNameText);
            // Card description
            transform.Find("background/forground/cardDescriptionText").gameObject.GetComponent<TextMeshProUGUI>().SetText(cardSO.CardDescriptionText);
            // Card type
            transform.Find("background/forground/cardTypeBackground/cardTypeText").gameObject.GetComponent<TextMeshProUGUI>().SetText(cardSO.CardTypeText);
            // Card mana
            transform.Find("background/forground/mana/manaCost").gameObject.GetComponent<TextMeshProUGUI>().SetText("{0}", cardSO.ManaCost);
            // Card gold
            transform.Find("background/forground/gold/goldCost").gameObject.GetComponent<TextMeshProUGUI>().SetText("{0}", cardSO.GoldCost);
            // Card damage
            transform.Find("background/forground/damageBackground/damageText").gameObject.GetComponent<TextMeshProUGUI>().SetText("{0}", cardSO.DamageAmount);
            // Card hp
            transform.Find("background/forground/defenceBackground/defenceText").gameObject.GetComponent<TextMeshProUGUI>().SetText("{0}", cardSO.HpAmount);
            // Card type
            cardType = cardSO.CardType;
            // Card damage type
            damageType = cardSO.DamageType;
            // Card defence type
            defenceType = cardSO.DefenceType;
        }
    }
}
