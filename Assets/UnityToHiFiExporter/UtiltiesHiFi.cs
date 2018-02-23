﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Random Utilities file to help the exporter and provide additional debugging
/// </summary>
public static class UtiltiesHiFi
{
	/// <summary>
	/// Finds the asset path folder that Unity stores things at
	/// </summary>
	/// <returns>The asset path folder.</returns>
	public static string GetAssetPathFolder()
	{
		string folderAssetsPath = Application.dataPath;
		return folderAssetsPath.Remove(folderAssetsPath.Length - 6, 6);
	}

	/// <summary>
	/// Asset folder without a slash (used for some cases)
	/// </summary>
	/// <returns>The asset path folder no end slash.</returns>
	public static string GetAssetPathFolderNoEndSlash()
	{
		string folderAssetsPath = Application.dataPath;
		return folderAssetsPath.Remove(folderAssetsPath.Length - 7, 7);
	}

	/// <summary>
	/// Finds the file name by parsing out the path
	/// </summary>
	public static string GetFileName(string pathWithFileName)
	{
		return pathWithFileName.Remove(0, pathWithFileName.LastIndexOf('/') + 1);
	}

	/// <summary>
	/// Finds whatever type of file extension this has
	/// </summary>
	public static string GetFileExtension(string pathWithFileName)
	{
		return pathWithFileName.Remove(0, pathWithFileName.LastIndexOf('.') + 1);
	}

	/// <summary>
	/// Find the folder from a path with a file name
	/// </summary>
	public static string GetFolderFromPath(string pathWithFileName)
	{
		int lastSlash = pathWithFileName.LastIndexOf('/') + 1;

		if(lastSlash <= 0)
		{
			Debug.LogError("path was not valid");
			return pathWithFileName;
		}

		return pathWithFileName.Remove(lastSlash, pathWithFileName.Length - lastSlash);
	}

	/// <summary>
	/// Remove a file extension so we have the file name withou the extension
	/// </summary>
	public static string RemoveFileExtension(string fileNameWithoutPath)
	{
		int period = fileNameWithoutPath.LastIndexOf('.');
		return fileNameWithoutPath.Remove(period, fileNameWithoutPath.Length - period);
	}

	/// <summary>
	/// Debug to show a vector with more details
	/// </summary>
	public static string ShowLongVector(Vector3 vector3)
	{
		return "(" + System.Math.Round((float)vector3.x, 5) + ", " + System.Math.Round((float)vector3.y, 5) + ", " +  System.Math.Round((float)vector3.z, 5) + ")";
	}

	/// <summary>
	/// Draw a line in 3D space
	/// </summary>
	public static void DrawLine(Vector3 start, Vector3 end, float time = 5)
	{
		if(time > 0)
			Debug.DrawLine(start, end, Color.white, time);
		else
			Debug.DrawLine(start, end);
	}

	/// <summary>
	/// Draw a cross in 3d space
	/// </summary>
	public static void Draw3DCross(Vector3 point, float size = 0.01f)
	{
		Draw3DCross(point, Color.white, size);
	}

	/// <summary>
	/// Draw a cross in 3d space
	/// </summary>
	public static void Draw3DCross(Vector3 point, float size, float duration)
	{
		Draw3DCross(point, size, duration, Color.white);
	}

	/// <summary>
	/// Draw a cross in 3d space
	/// </summary>
	public static void Draw3DCross(Vector3 point, float size, Color color)
	{
		Draw3DCross(point, color, size);
	}

	/// <summary>
	/// Draw a cross in 3d space
	/// </summary>
	public static void Draw3DCross(Vector3 point, float size, Color color, float duration)
	{
		Draw3DCross(point, size, duration, color);
	}

	/// <summary>
	/// Draw a cross in 3d space
	/// </summary>
	public static void Draw3DCross(Vector3 point, Color color)
	{
		Draw3DCross(point, color, 0.01f);
	}

	/// <summary>
	/// Draw a cross in 3d space
	/// </summary>
	public static void Draw3DCross(Vector3 point, Color color, float size)
	{
		Debug.DrawLine(point, point + Vector3.up * size, color);
		Debug.DrawLine(point, point + Vector3.down * size, color);
		Debug.DrawLine(point, point + Vector3.right * size, color);
		Debug.DrawLine(point, point + Vector3.left * size, color);
		Debug.DrawLine(point, point + Vector3.forward * size, color);
		Debug.DrawLine(point, point + Vector3.back * size, color);
	}

	/// <summary>
	/// Draw a cross in 3d space
	/// </summary>
	public static void Draw3DCross(Vector3 point, float size, float duration, Color color)
	{
		Debug.DrawLine(point, point + Vector3.up * size, color, duration);
		Debug.DrawLine(point, point + Vector3.down * size, color, duration);
		Debug.DrawLine(point, point + Vector3.right * size, color, duration);
		Debug.DrawLine(point, point + Vector3.left * size, color, duration);
		Debug.DrawLine(point, point + Vector3.forward * size, color, duration);
		Debug.DrawLine(point, point + Vector3.back * size, color, duration);
	}

}
