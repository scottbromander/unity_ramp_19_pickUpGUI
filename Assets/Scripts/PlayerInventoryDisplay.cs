using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour {
	public Image[] starPlaceHolders;

	public Sprite iconStarYellow;
	public Sprite iconStarGrey;

	public void OnChangeCarryingStar(int starTotal){
		for(int i = 0; i < starPlaceHolders.Length; i++){
			if (i < starTotal) {
				starPlaceHolders [i].sprite = iconStarYellow;
			} else {
				starPlaceHolders [i].sprite = iconStarGrey;
			}
		}
	}
}
