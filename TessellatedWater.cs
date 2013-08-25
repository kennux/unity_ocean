using UnityEngine;

// Sets up transformation matrices to scale&scroll water waves
// for the case where graphics card does not support vertex programs.

[ExecuteInEditMode]
public class TessellatedWater : MonoBehaviour
{
	
	void Update()
	{
		if( !renderer )
			return;
		Material mat = renderer.sharedMaterial;
		if( !mat )
			return;
			
		Vector4 waveSpeed = mat.GetVector( "WaveSpeed" );
		Vector4 dispSpeed = mat.GetVector( "DispSpeed" );
		float waveScale = mat.GetFloat( "_WaveScale" );
		float t = Time.time / 20.0f;
		
		// Bump
		Vector4 offset4 = waveSpeed * (t * waveScale);
		Vector4 offsetClamped = new Vector4(Mathf.Repeat(offset4.x,1.0f), Mathf.Repeat(offset4.y,1.0f), Mathf.Repeat(offset4.z,1.0f), Mathf.Repeat(offset4.w,1.0f));
		mat.SetVector( "_WaveOffset", offsetClamped );
		
		// Displacement
		Vector4 offset4disp = dispSpeed * (t);
		Vector4 offsetdispClamped = new Vector4(Mathf.Repeat(offset4disp.x,1.0f), Mathf.Repeat(offset4disp.y,1.0f), Mathf.Repeat(offset4disp.z,1.0f), Mathf.Repeat(offset4disp.w,1.0f));
		mat.SetVector( "_DispOffset", offsetdispClamped );
	}
}
