using System.Collections;
using UnityEngine;

public static class AudioFadeOut
{
	public static IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
	{
		float startVolume = audioSource.volume;
		while (audioSource.volume > 0f)
		{
			audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
			yield return null;
		}
		audioSource.Stop();
		audioSource.volume = startVolume;
	}

	public static IEnumerable FadeOut(float FadeTime)
	{
		yield return null;
	}
}
