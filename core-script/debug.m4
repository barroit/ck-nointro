dnl SPDX-License-Identifier: GPL-3.0-or-later
dnl
divert(-1)

ifdef([[NDEBUG]], [[dnl
  define(LOG)
]], [[dnl
  define(LOG, UnityEngine.Debug.Log($"NAME: {$1}");)
]])

divert(0)dnl
