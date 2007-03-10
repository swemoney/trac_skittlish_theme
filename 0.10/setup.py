#!/usr/bin/env python
# -*- coding: iso-8859-1 -*-

from setuptools import setup

setup(
    name = 'TracSkittlishTheme',
    version = '1.0',
    packages = ['skittlishtheme'],
    package_data = { 'skittlishtheme': ['templates/*.cs', 'htdocs/images/*.*', 'htdocs/*.*' ] },

    author = "Steve 'dnite' Ehrenberg",
    author_email = "steve@dnite.org",
    description = "A port of the mephisto theme, Skittlish, created by evil.che.lu.",
    license = "BSD",
    keywords = "trac plugin theme",
    url = "http://trac-hacks.org/wiki/SkittlishTheme",
    classifiers = [
        'Framework :: Trac',
    ],
    
    install_requires = ['TracThemeEngine'],

    entry_points = {
        'trac.plugins': [
            'skittlishtheme.theme = skittlishtheme.theme',
        ]
    }
)
