using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class statusbar : MonoBehaviour
{
    public health playerhealth;
    public Image fillimage;
    private Slider slider;
    // Start is called before the first frame update
    void Awake()
    {
        
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        healthvalue();
    }

    private void healthvalue()
    {
        float fillValue = playerhealth.currentHealth / playerhealth.maxHealth;
        slider.value = fillValue;
    }
}
