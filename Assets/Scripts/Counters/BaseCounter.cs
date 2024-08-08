using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent {

    // It's personal preference whether to use type 'Transform' or 'GameObject' for when declaring a prefab
    [SerializeField] private Transform counterTopPoint;

    private KitchenObject kitchenObject;

    // the 'protected' accessor is visible to this class and any class inheriting it
    // 'virtual' allows the child class to implement in their own way
    // 'abstract' is an alternative to 'virtual' which forces all child classes to have their own implementation
    public virtual void Interact(Player player) {
        Debug.LogError("BaseCounter.Interact(); entered which shouldn't happen");
    }

    public virtual void InteractAlternate(Player player) {
        // Debug.LogError("BaseCounter.Interact(); entered which shouldn't happen");
    }

    public Transform GetKitchenObjectFollowTransform() {
        return counterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject) {
        this.kitchenObject = kitchenObject;
    }

    public KitchenObject GetKitchenObject() {
        return kitchenObject;
    }

    public void ClearKitchenObject() {
        kitchenObject = null;
    }

    public bool HasKitchenObject() {
        return kitchenObject != null;
    }
}
