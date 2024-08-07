using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter {

    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    
    public override void Interact(Player player) {
        if (!HasKitchenObject()) {
            // There's no kitchen object here
            if (player.HasKitchenObject()) {
                // Player is carrying a kitchen object
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else {
                // Player is not carrying anything so do nothing
            }
        } else {
            // There's a kitchen object here
            if (player.HasKitchenObject()) {
                // Player is carrying a kitchen object so do nothing
            } else {
                // Player is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
