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
    private int _maxHp = 100;
    [SerializeField] private int _hp;
    public int Hp
    {
        get => _hp;
        set
        {
            _hp = value;
            
            hpSlider.value = _hp;
            if(hpText != null)
            {
                hpText.text = _hp.ToString();
            }
            if(_hp >= _maxHp)
            {
                _hp = _maxHp;
            }
            if (_hp <= 0)
            {
                Death();
            }
        }
    }
    private void Start()
    {
        Hp = _maxHp;
        hpSlider.maxValue = _maxHp; 
        hpSlider.value = _maxHp; 
        anim = GetComponent<Animator>();
        if(anim == null)
        {
            anim = GetComponentInChildren<Animator>();
        }
    }
    public void Hit(string _anim, int damage)
    {
        Hp -= damage;
        Debug.LogError("Hit");
        anim.SetTrigger(_anim);
    }
    private void Death()
    {

    }
}
