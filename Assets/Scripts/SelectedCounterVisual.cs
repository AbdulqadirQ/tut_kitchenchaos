using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour {

    [SerializeField] private ClearCounter clearCounter;
    [SerializeField] private GameObject visualGameObject;

    // is run on Start() since the Player Instance is set upon Awake(), so should now always run after instantiation of Player
    private void Start() {
        Player.Instance.OnSelectedCounterChanged += Instance_OnSelectedCounterChanged;
    }

    private void Instance_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e) {
        if (e.selectedCounter == clearCounter) {
            Show();
        } else {
            Hide();
        }
    }

    private void Show() {
        visualGameObject.SetActive(true);
    }

    private void Hide() {
        visualGameObject.SetActive(false);
    }
}
