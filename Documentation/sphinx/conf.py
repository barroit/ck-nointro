# SPDX-License-Identifier: GPL-3.0-or-later

copyright = '2025, 2026 Jiamu Sun'
author = 'Jiamu Sun'

project = 'nointro'
version = 'v0.1'
release = version

needs_sphinx = '8.2'
smartquotes_action = 'q'

extensions = []

primary_domain = 'c'
highlight_language = 'none'

templates_path = [ 'templates' ]
exclude_patterns = [ 'build' ]

html_theme = 'alabaster'
html_static_path = [ 'static' ]

html_logo = 'images/cherry.svg'
html_favicon = 'images/cherry.png'

html_css_files = [
	'block.css',
	'custom.css',
	'font.css',
	'toc.css',
]

html_theme_options = {
	'description': version,
	'page_width': '65em',
	'sidebar_width': '20em',
	'fixed_sidebar': 'true',
	'font_size': 'inherit',
	'font_family': 'serif',
}

html_sidebars = {
	'**': [
		'about.html',
		'searchbox.html',
		'toc.html',
		'sourcelink.html',
	],
}
