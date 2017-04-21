﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
public class GameUIManager : MonoBehaviour {
	public Image BlackCover;
	public Image BloodBlur;
	public Text HPText;
	public Image HPBAR;
	public Image MPBAR;
	// Use this for initialization
	void Start () {
		BlackCover.color = Color.black;
		DOTween.To (() => BlackCover.color, (x) => BlackCover.color = x, new Color (0, 0, 0, 0), 1f);
	}
	Tweener tweenAnimation;
	public void PlayHitAnimation()
	{
		if (tweenAnimation != null)
			tweenAnimation.Kill ();

		BloodBlur.color = Color.white;
		tweenAnimation = DOTween.To (() => BloodBlur.color, (x) => BloodBlur.color = x, new Color (1, 1, 1, 0), 0.5f);
	}
	public void PlayerDiedAnimation()
	{
		BloodBlur.color = Color.white;
		DOTween.To (() => BlackCover.color, (x) => BlackCover.color = x, new Color (0, 0, 0, 1), 1f).SetDelay(3);
	}
	public void SetHP(int hp)
	{
		HPBAR.fillAmount = hp/100f;
		if (hp < 20)
			HPBAR.color = Color.red;
		else
			HPBAR.color = new Color (0.251f,1f,0.251f);
	}
	public void SetMP(float mp)
	{
		MPBAR.fillAmount = mp/10f;
	}
}