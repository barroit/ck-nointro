// SPDX-License-Identifier: GPL-3.0-or-later
/*
 * Copyright 2026 Jiamu Sun <barroit@linux.com>
 */
divert(-1)

define(SCENE, Manager.main.currentSceneHandler)

define(DELAY_SKIP_LOGO, 1.1f)
define(DELAY_SKIP_TEXT, .15f)

define(BLACK_TO_BLACK, FadePresets.blackToBlack)

divert(0)dnl

using System.Collections;
using UnityEngine;

using PugMod;

public class init : IMod {

delay delay;

public void EarlyInit()
{
	state.fs = API.ConfigFilesystem;
	delay = state.load();

	LOG($"skip_logo: {delay.skip_logo}s")
	LOG($"skip_text: {delay.skip_text}s")

	if (delay.skip_logo == 0f) {
		delay.skip_logo = DELAY_SKIP_LOGO;
		delay.skip_text = DELAY_SKIP_TEXT;

		state.save(delay);
	}
}

IEnumerator skip_intro(delay delay)
{
	yield return new WaitForSeconds(delay.skip_logo);
	Manager.load.QueueScene("Title", 0.1f, 0.1f, BLACK_TO_BLACK, false, 0);

	yield return new WaitForSeconds(delay.skip_text);
	SCENE.titleScreenAnimator.SetTitleTextEnabled(false);
}

public void Init()
{
	var seq = skip_intro(delay);

	Manager.main.StartCoroutine(seq);
}

public void ModObjectLoaded(Object _) {}

public void Update() {}

public void Shutdown() {}

} /* class init */
