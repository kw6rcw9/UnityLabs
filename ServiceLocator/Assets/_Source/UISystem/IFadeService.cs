using System;
using UnityEngine;

namespace UISystem
{
    public interface IFadeService
    {
        void FadeIn(CanvasGroup canvasGroup, float duration);
        void FadeOut(CanvasGroup canvasGroup, float duration);
        void FadeIn(CanvasGroup canvasGroup, float duration, Action onComplete);
        void FadeOut(CanvasGroup canvasGroup, float duration, Action onComplete);
    }
}
