using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharacterPreviewController : MonoBehaviour {
	
	public Text charNameText;
	public Text camRotateXText;
	
	public RuntimeAnimatorController[] animController;
	public GameObject[] characters;
	public string[] charNames;
	
	Vector3 instantiatePos 	  = new Vector3 (0, 0, 0);
	Quaternion instantiateRot = new Quaternion (0, 0, 0, 1);
	Renderer[] rend;
	int charIndex, animIndex;
	int charCount, animCount;

	CameraMovement camMove;
	bool rotateCam = true;
	

	void Start () {
		camMove = Camera.main.GetComponent<CameraMovement> ();
		RotateCam ();
	}
	
	// Use this for initialization
	void Awake () {

		if (characters != null) {
			charIndex = 0;
			animIndex = 0;

			charCount = characters.Length;
			animCount = animController.Length;

			charNames = new string[charCount];
			
			foreach (GameObject c in characters) {
				charNames [charIndex] = c.name;
				characters [charIndex] = Instantiate (c, instantiatePos, instantiateRot) as GameObject;
				characters [charIndex].transform.parent = gameObject.transform;

				characters [charIndex].GetComponent<Animator>().runtimeAnimatorController = animController[animIndex];

				//set character render to false except first character
				rend = characters [charIndex].GetComponentsInChildren<Renderer> ();
				foreach (Renderer r in rend) {
					if(charIndex != 0)
						r.enabled = false;
				}
				++charIndex;
			}
			
			charIndex = 0;
			charNameText.text = charNames[charIndex];
		}
	}
	
	public void NextChar(){

		rend = characters[charIndex].GetComponentsInChildren<Renderer>();
		foreach (Renderer r in rend) {
			r.enabled = false;
		}
		
		if (charIndex >= charCount - 1)
			charIndex = 0;
		else
			++charIndex;

		rend = characters[charIndex].GetComponentsInChildren<Renderer>();
		foreach (Renderer r in rend) {
			r.enabled = true;
		}
		charNameText.text = charNames[charIndex];
	}
	
	public void PrevChar(){
		
		rend = characters[charIndex].GetComponentsInChildren<Renderer>();
		foreach (Renderer r in rend) {
			r.enabled = false;
		}
		
		if (charIndex <= 0)
			charIndex = charCount - 1;
		else
			--charIndex;
		
		rend = characters[charIndex].GetComponentsInChildren<Renderer>();
		foreach (Renderer r in rend) {
			r.enabled = true;
		}
		charNameText.text = charNames[charIndex];
	}

	public void NextAnim() {

		if (animIndex >= animCount - 1)
			animIndex = 0;
		else
			++animIndex;

		for (int i = 0; i < charCount; i ++) {
			characters [i].GetComponent<Animator>().runtimeAnimatorController = animController[animIndex];
		}
	}

	public void PrevAnim() {
		
		if (animIndex <= 0)
			animIndex = animCount - 1;
		else
			--animIndex;
		
		for (int i = 0; i < charCount; i ++) {
			characters [i].GetComponent<Animator>().runtimeAnimatorController = animController[animIndex];
		}
	}

	public void RotateCam() {

		if (rotateCam) {
			camMove.enabled = true;
			camRotateXText.enabled = true;
			rotateCam = false;
		} else {
			camMove.enabled = false;
			camRotateXText.enabled = false;
			rotateCam = true;
		}
	}
}
