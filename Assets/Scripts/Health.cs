using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private Slider hpSlider;
    [SerializeField] private TextMeshProUGUI hpText;
    private int _hp;
    public int Hp
    {
        get => _hp;
        set
        {
            _hp = value;
            hpSlider.value = _hp;
            hpText.text = _hp.ToString();
            if (Hp <= 0)
            {
                Death();
            }
        }
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
        if(anim == null)
        {
            anim = GetComponentInChildren<Animator>();
        }
    }
    public void Hit(string _anim, int damage)
    {
        Debug.LogError("Hit");
        anim.SetTrigger(_anim);
    }
    private void Death()
    {

    }
}
