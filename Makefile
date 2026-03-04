# SPDX-License-Identifier: GPL-3.0-or-later

m4 ?= m4
onchange ?= onchange

patch-m4  := core-script/patch.m4
helper-m4 := $(filter-out $(patch-m4),$(wildcard core-script/*.m4))
script-in := $(wildcard core-script/*.cs)
script-y  := $(subst -script,,$(script-in))

.PHONY: pp

pp:

$(script-y): core%: core-script%
	$(m4) $${DEBUG:+-DDEBUG} $(patch-m4) $(helper-m4) $< >$@

pp: $(script-y)

.PHONY: hot-pp

hot-pp: pp
	$(onchange) 'core-script/*' -- $(MAKE) pp

.PHONY: clean

clean:
	rm -f $(script-y)
