using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class StarsView : MonoBehaviour
{
    [SerializeField] private GameObject[] stars;

    [SerializeField] private Color defaultColor;
     private const float _morningStars = 0.2f;
     private const float _dayStars = 0;
     private const float _eveningStars = 0.2f;
     private const float _nightStars = 1f;


    private void Awake()
    {
        foreach (var star in stars)
        {
            star.TryGetComponent(out SpriteRenderer sprite);
            sprite.color = defaultColor;
        }
        Stars.OnStarsChange += UpdateStars;
    
    }

    private void OnDisable()
    {
        Stars.OnStarsChange -= UpdateStars;
    }

    public void SetMorning(float time) => SetStarsAlpha(_morningStars, time);

    public void SetNight(float time) => SetStarsAlpha(_nightStars, time);
    public void SetDay(float time) => SetStarsAlpha(_dayStars, time);
    public void SetEvening(float time) => SetStarsAlpha(_eveningStars, time);

    private void UpdateStars(DayState dayState, float time)
    {
        switch (dayState)
        {
            case DayState.Morning:
                SetMorning(time);
                break;
            case DayState.Night:
                SetNight(time);
                break;
            case DayState.Day:
                SetDay(time);
                break;
            case DayState.Evening:
                SetEvening(time);
                break;
        }
    }
    public void  SetStarsAlpha(float dayTime, float time)
    {
        foreach (var star in stars)
        {
            
            if(star.TryGetComponent(out SpriteRenderer sprite))
                sprite.DOFade(dayTime, time);
        }

    }
}
