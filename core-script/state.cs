// SPDX-License-Identifier: GPL-3.0-or-later
/*
 * Copyright 2024-2026 Jiamu Sun <barroit@linux.com>
 */
define(CONFIG, "NAME.json")dnl

using System;
using System.Text;
using UnityEngine;

using PugMod;

[Serializable]
public struct delay {
	/*
	 * FIXME: Treat each version bump as a value transformation, and build
	 *        the final version's value bottom up.
	 */
	public int version;

	public float skip_logo;
	public float skip_text;
}

public class state {

public static IConfigFilesystem fs;

public static void save(in delay data)
{
	string json = JsonUtility.ToJson(data, true);
	byte[] raw = Encoding.UTF8.GetBytes(json);

	fs.Write(CONFIG, raw);
}

public static delay load()
{
	if (!fs.FileExists(CONFIG))
		return default;

	byte[] buf = fs.Read(CONFIG);
	string json = Encoding.UTF8.GetString(buf);

	try {
		return JsonUtility.FromJson<delay>(json);
	} catch (Exception) {
		return default;
	}
}

} /* class state */
