using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class VirtualJoystickScript : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler {

	private Image bgImage;
	private Image joystickImage;
	private Vector3 inputVector;

	public GameObject playerCamera;
	public float movementMultiplier = 0.2f;

	// Use this for initialization
	void Start () {
		bgImage = GetComponent<Image> ();
		joystickImage = transform.GetChild (0).GetComponent<Image> ();
	}

	public virtual void OnDrag(PointerEventData ped){
		Vector2 pos;

		if(RectTransformUtility.ScreenPointToLocalPointInRectangle(bgImage.rectTransform,
																	ped.position,
																	ped.pressEventCamera,
																	out pos)) {

			pos.x = (pos.x / bgImage.rectTransform.sizeDelta.x);
			pos.y = (pos.y / bgImage.rectTransform.sizeDelta.y);

			inputVector = new Vector3 (pos.x*2 + 1, 0, pos.y*2 - 1);
			inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;

			joystickImage.rectTransform.anchoredPosition = 
				new Vector3 (inputVector.x * (bgImage.rectTransform.sizeDelta.x / 3) ,
					inputVector.z * (bgImage.rectTransform.sizeDelta.y / 3) );

			Vector3 posToMove = new Vector3 (inputVector.x * movementMultiplier, 0f, inputVector.z * movementMultiplier);


			playerCamera.transform.position = (playerCamera.transform.position + (posToMove));
		}
	}

	public virtual void OnPointerDown(PointerEventData ped){
		OnDrag (ped);
	}

	public virtual void OnPointerUp(PointerEventData ped){
		inputVector = Vector3.zero;
		joystickImage.rectTransform.anchoredPosition = Vector3.zero;
	}

}
