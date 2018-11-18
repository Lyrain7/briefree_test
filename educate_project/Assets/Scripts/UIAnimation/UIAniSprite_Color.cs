using UnityEngine;
using System.Collections;
using Holoville.HOTween;

public class UIAniSprite_Color : MonoBehaviour {

    public UISprite sprite;

    public bool resetWhenFirstStart = true;

    public Color startColor;
    public Color endColor;
    public Color currentColor;

    public float animationTime = 0.5f;


    private Tweener twn;

    public void PlayAnimation ()
    {
        if ( resetWhenFirstStart )
        {
            resetWhenFirstStart = false;

            currentColor = startColor;
            sprite.color = startColor;
        }

        Util.ClearHotween ( ref twn );

        twn = HOTween.To( this , animationTime , new TweenParms().Prop("currentColor", endColor , false ).Ease ( EaseType.EaseInExpo ).OnUpdate ( ChangeColor ) );
    }


    public void StopAnimation ()
    {
        Util.ClearHotween ( ref twn );

        currentColor = startColor;

        ChangeColor ();
    }



    private void ChangeColor ()
    {
        sprite.color = currentColor;
    }
}