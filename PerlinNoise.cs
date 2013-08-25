using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class PerlinNoise : MonoBehaviour
{
	private Texture2D permutationTable;
	
	// Use this for initialization
	public void Start ()
	{
		Random.seed = (int) Time.time;
		this.generatePermutation((int) (Random.value * 100));
	}
	
	// Update is called once per frame
	public void Update ()
	{
		// Update the texture here for setting new random values
		// this.updatePermutation ();
		// this.generatePermutation((int) (Random.value * 100));
		this.renderer.sharedMaterial.SetTexture ("_PermutationTable", this.permutationTable);
	}
	
	// Perlin noise implementation
	public void generatePermutation(int seed)
	{
		Random.seed = seed;
		
		// 256 Permutation 
		this.permutationTable = new Texture2D(256, 1, TextureFormat.Alpha8, false);
		
		
		for(int i = 0; i < this.permutationTable.width; i++)
		{
			float permVal = Random.value;
			this.permutationTable.SetPixel (i, 0, new Color(permVal, permVal, permVal, permVal));
		}
		
		this.permutationTable.Apply ();
	}
	
	public void updatePermutation()
	{
		Texture2D newTex = new Texture2D(256, 1, TextureFormat.Alpha8, false);
		
		// Fast copy
		newTex.SetPixels(1,0,255,1,this.permutationTable.GetPixels (1,0,255,1));
		
		Random.seed = (int)Time.time;
		float permVal = Random.value;
		newTex.SetPixel (0, 0, new Color(permVal, permVal, permVal, permVal));
		
		newTex.Apply ();
		
		this.permutationTable = newTex;
	}
	
	/*public void OnGUI()
	{
		GUI.DrawTexture (new Rect(0,0,256,20), this.permutationTable);	
	}*/
}
