using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FishItem : MonoBehaviour, IInteractable
{
    public float increaseDmgBy = 0.3f;
    public float increaseRangeBy = 2f;
    private string title = "Big Fish";
    private string description = "Your Gun Is feeling stronger... Damage and range up";
    [SerializeField] public int price = 7;
    [SerializeField] private TMP_Text priceText;

    void Start()
    {
        // Set the price text
        priceText.text = price + "C";
    }
    public void Interact()
    {
        if (CanInteract())
        {
            // Check if the player has enough coins to purchase
            if (Coin.coins >= price)
            {
                PlayerGun playerGun = PlayerGun.Instance;
                playerGun.damage += increaseDmgBy;
                playerGun.travelTime += increaseRangeBy;
                PopupManager.Instance.ShowPopup(title, description, 2.5f);
                transform.parent.gameObject.SetActive(false);
                Coin.coins -= price;
                Coin.UpdateCoinCountText();
            }
            else
            {
                PopupManager.Instance.ShowPopup("Not Enough Coins", "Collect More Coins", 2.5f);
            }
        }
    }

    public bool CanInteract()
    {
        // Add conditions if the item can be bought
        return true;
    }
}
