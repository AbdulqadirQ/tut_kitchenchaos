using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarUI : MonoBehaviour {

    [SerializeField] private CuttingCounter cuttingCounter;
    [SerializeField] private Image barImage;

    private void Start() {
        cuttingCounter.OnProgressChanged += CuttingCounter_OnProgressChanged;

        barImage.fillAmount = 0;
    }

    private void CuttingCounter_OnProgressChanged(object sender, CuttingCounter.OnProgresChangedEventArgs e) {
        barImage.fillAmount = e.progressNormalized;
    }
}
