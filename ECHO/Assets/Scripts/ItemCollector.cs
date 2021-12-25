using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int pines = 0;

    [SerializeField] private Text pinesText;

private void OnTriggerEnter2D(Collider2D collision)
{
    if (collision.gameObject.CompareTag("Pine"))
    {
        Destroy(collision.gameObject);
        pines++;
        pinesText.text = "Your Score: " + pines;
    }    
}
}
