using UnityEngine;
using System.Collections;

namespace Vuforia {
	public class Configuration : MonoBehaviour {
		void Start () 
		{
			VuforiaBehaviour.Instance.RegisterVuforiaStartedCallback(OnVuforiaStarted);
			VuforiaBehaviour.Instance.RegisterOnPauseCallback(OnPaused);
		}

		private void OnVuforiaStarted()
		{
			CameraDevice.Instance.SetFocusMode(
				CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
		}

		private void OnPaused(bool paused)
		{
			if (!paused) // resumed
			{
				// Set again autofocus mode when app is resumed
				CameraDevice.Instance.SetFocusMode(
					CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
			}
		}
	}
}
