using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;
using VRStandardAssets.Utils;


public class VRClickUIHelper : MonoBehaviour {

	public UnityEvent onClickEvents;
	public UnityEvent onDoubleClick;

	public void InvokeEvents() {
		 onClickEvents.Invoke();
	}

	public void InvokeDoubleClickEvents() {
		onDoubleClick.Invoke();
	}

	void OnEnable() {
		VRInteractiveItem item = gameObject.GetComponent<VRInteractiveItem>();
		item.OnClick += InvokeEvents;
		item.OnDoubleClick += InvokeDoubleClickEvents;
	}

	void OnDisable() {
		VRInteractiveItem item = gameObject.GetComponent<VRInteractiveItem>();
		item.OnClick -= InvokeEvents;
		item.OnDoubleClick -= InvokeDoubleClickEvents;
	}
}
