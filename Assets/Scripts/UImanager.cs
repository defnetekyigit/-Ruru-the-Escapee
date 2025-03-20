using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI collectableAmountText;
    [SerializeField] Transform HealthBar;
    [SerializeField] PlayerController playerController;

    private void Update()
    {
        DisplayHealthBar();
    }

    public void DisplayCollected()
    {
        collectableAmountText.text = playerController.collectableAmount.ToString();

    }
    void DisplayHealthBar()
    {
        float percent = playerController.currentHealth / 100;
        HealthBar.localScale = new Vector3(percent, 1, 1);
    }
}
