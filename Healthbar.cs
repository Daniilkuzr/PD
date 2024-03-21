using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour
{
    public Slider slider;
    public Vector3 offset;
    public float maxHealth;
    public Transform enemy;

    public void SetHealth(float health)
    {
        slider.gameObject.SetActive(health < maxHealth);
        slider.value = health;
        slider.maxValue = maxHealth;
    }





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public  void Update()
    {
        slider.transform.position = enemy.transform.position+offset;
        
    }
}
