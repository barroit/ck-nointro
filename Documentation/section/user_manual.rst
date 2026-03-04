.. SPDX-License-Identifier: GPL-3.0-or-later

===========
User Manual
===========

This mod is dead simple. It skips the intro, and the only thing you can
configure is how long it waits before skipping each screen.

There is no in-game UI for this. You edit the configuration file directly.

Configuration File
==================

The configuration file is :file:`nointro.json`. Its location depends on how you
run the game:

Windows
	|path_win|

Linux
	|path_linux|

Linux with Proton
	|path_proton|

Replace ``<user>`` with your Steam user ID.

File Format
===========

The file uses this schema::

	{
	    "skip_logo": 1.100000023841858,
	    "skip_text": 0.15000000596046449
	}

Both values are delays, in seconds.

``skip_logo`` is the delay before skipping the logo screen. This is the screen
that appears after the loading progress screen you see when the game starts.

``skip_text`` is the delay before skipping the text screen. This is the screen
that appears after the logo screen.

Defaults
========

The default value of ``skip_logo`` is ``1.39``. The default value of
``skip_text`` is ``0.15``.

These defaults are calibrated for standard hardware. Tune as needed for your
system.

If you break the file, delete it. The mod will generate a new one with default
values.

.. |path_win| replace:: :file:`$env:USERPROFILE/AppData/LocalLow/Pugstorm/\
			       Core\` Keeper/Steam/<user>/mods/nointro.json`

.. |path_linux| replace:: :file:`$HOME/.config/unity3d/Pugstorm/\
				 Core\\ Keeper/Steam/<user>/mods/nointro.json`

.. |path_proton| replace:: :file:`/path/to/game/../../compatdata/1621690/pfx/\
				  drive_c/users/steamuser/AppData/LocalLow/\
				  Pugstorm/Core\\ Keeper/Steam/<user>/mods/\
				  nointro.json`
