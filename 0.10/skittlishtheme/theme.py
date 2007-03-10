from trac.core import *

from themeengine.api import ThemeBase

__all__ = ['SkittlishTheme']

class SkittlishTheme(ThemeBase):
    """A port of the mephisto theme, Skittlish, created by evil.che.lu."""
    
    header = footer = css = htdocs = screenshot = True
