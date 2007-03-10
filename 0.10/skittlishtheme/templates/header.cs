<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="en" xml:lang="en">
<head>
  <title>
    <?cs if:project.name_encoded ?>
      <?cs if:title ?><?cs var:title ?> - <?cs /if ?>
      <?cs var:project.name_encoded ?> - Trac
    <?cs else ?>
      Trac: <?cs var:title ?>
    <?cs /if ?>
  </title>
  <?cs if:html.norobots ?>
    <meta name="ROBOTS" content="NOINDEX, NOFOLLOW" />
  <?cs /if ?>
  <?cs each:rel = chrome.links ?>
    <?cs each:link = rel ?>
      <link rel="<?cs var:name(rel) ?>" href="<?cs var:link.href ?>"
        <?cs if:link.title ?> title="<?cs var:link.title ?>"<?cs /if ?>
        <?cs if:link.type ?> type="<?cs var:link.type ?>"<?cs /if ?> />
    <?cs /each ?>
  <?cs /each ?>
  <style type="text/css"><?cs include:"site_css.cs" ?></style>
  <?cs each:script = chrome.scripts ?>
    <script type="<?cs var:script.type ?>" src="<?cs var:script.href ?>"></script>
  <?cs /each ?>
</head>

<body>

<body class="fixed green">

<div id="wrapper">

  <?cs def:nav(items, class, filter) ?>
    <?cs if:len(items) ?>
      <?cs set:idx = 0 ?>
      <?cs set:max = len(items) - 1 ?>
      <?cs each:item = items ?>
        <?cs set:first = idx == 0 ?>
        <?cs set:last = idx == max ?>
        <?cs if:filter == 1 && name(item)!='login' && name(item)!='register' || filter == 0?>
          <li<?cs if:first || last || item.active ?> class="<?cs if:item.active ?>selected<?cs /if ?>
            <?cs if:item.active && (first || last) ?> <?cs /if ?>
            <?cs if:first ?>first<?cs /if ?><?cs if:(item.active || first) && last ?> <?cs /if ?>
            <?cs if:last ?>last<?cs /if ?>"<?cs /if ?>><?cs var:item ?></li>
        <?cs /if ?>
        <?cs set:idx = idx + 1 ?>
      <?cs /each ?>
    <?cs /if ?>
  <?cs /def ?>

  <div id="skit_header" class="clearfix">
    <div id="skit_title" class="clearfix">
      <?cs if:chrome.logo.src ?>
        <a id="logo" href="<?cs var:chrome.logo.link ?>">
          <img src="<?cs var:chrome.logo.src ?>"
            <?cs if:chrome.logo.width ?> width="<?cs var:chrome.logo.width ?>"<?cs /if ?>
            <?cs if:chrome.logo.height ?> height="<?cs var:chrome.logo.height ?>"<?cs /if ?> 
            alt="<?cs var:chrome.logo.alt ?>" />
        </a>
      <?cs elif:project.name_encoded ?>
        <h3><a href="<?cs var:chrome.logo.link ?>"><?cs var:project.name_encoded ?></a></h3>
      <?cs /if ?>
    </div>
    <ul id="skit_metamenu">
      <?cs call:nav(chrome.nav.metanav, '', 0) ?>
    </ul>
    <ul id="skit_menu">
      <?cs call:nav(chrome.nav.mainnav, '', 0) ?>
    </ul>
  </div>

<!-- No search box for now
<form id="search" action="<?cs var:trac.href.search ?>" method="get">
 <?cs if:trac.acl.SEARCH_VIEW ?><div>
  <label for="proj-search">Search:</label>
  <input type="text" id="proj-search" name="q" size="10" accesskey="f" value="" />
  <input type="submit" value="Search" />
  <input type="hidden" name="wiki" value="on" />
  <input type="hidden" name="changeset" value="on" />
  <input type="hidden" name="ticket" value="on" />
 </div><?cs /if ?>
</form>
-->

  <div id="skit_contentwrapper" class="clearfix">

  <div id="skit_content">
      
