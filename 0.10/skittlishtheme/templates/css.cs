/* Main Styles */
* {
  margin: 0px;
  padding: 0px;
}

body {
  background: #e3e3e3 url(<?cs var:chrome.href ?>/theme/images/bg.gif) repeat-x;
  color: #1b1b1b;
  font: normal 76% Verdana, Arial, Helvetica, sans-serif;
  margin: 0px;
}

li {
  list-style-type: none;
}

a img {
  border-style: none;
}

a {
  color: #095eae;
  font-weight: bold;
  text-decoration: none;
}

a:hover {
  text-decoration: none;
}

h1, h2, h3, h4, h5, h6 {
  margin-top: 0em;
  margin-bottom: .25em;
  font-weight: normal;
  font-family: "Lucida Grande", "Lucida Sans Unicode", "Lucida Sans", "Trebuchet MS", Verdana, sans-serif;
}

h1 { font-size: 2.6em; }
h2 { font-size: 2.3em; }
h3 { font-size: 2.0em; }
h4 { font-size: 1.8em; }
h5 { font-size: 1.6em; }
h6 { font-size: 1.4em; }

p {
  margin-bottom: 1em;
  line-height: 1.3;
}

ul.list, ol.list {
  margin-left: 3em;
  margin-bottom: 1em;
}

.list li {
  margin-bottom: .5em;
  color: #1b1b1b;
}

ul.list li {
  list-style-type: disc;
}

ol.list li {
  list-style-type: decimal;
}

/* Fix the clears */
.clearfix:after {
  content: ".";
  display: block;
  height: 0;
  clear: both;
  visibility: hidden;
}

/* Main Wrapper */
#wrapper {
  position: relative;
  width: 980px;
  margin: 0 auto;
  padding-right: 5px;
  border-left: solid 1px #9a9a9a;
  background: url(<?cs var:chrome.href ?>/theme/images/left_bg.gif) right repeat-y;
  font-size: 1.11em;
}

#wrapper a {
  color: #61ac00;
  text-decoration: none;
  border-bottom: 0px solid;
}

#wrapper a:hover {
  background-color: transparent;
  text-decoration: none;
  border-bottom: 0px solid;
}

#wrapper a:visited {
}

/* header */
#skit_header {
  padding: 20px 0 20px 30px;
  border-bottom: solid 1px #343434;
  background: #1c1c1c url(<?cs var:chrome.href ?>/theme/images/header_bg.gif) repeat-x;
}

#skit_header h3 {
  float: left;
  margin-bottom: 0;
  font-size: 2em;
  font-weight: normal;
}

#skit_header h3 a {
  display: block;
  padding-top: 0.75em;
  color: #bababa;
}

#skit_header h3 a:hover {
  text-decoration: none;
}

/* main and meta menus */
#skit_menu, #skit_metamenu {
  clear: both;
  float: right;
  display: inline;
  margin-right: 15px;
  text-align: right;
}

#skit_menu li, #skit_metamenu li {
  display: inline;
  margin-right: 10px;
  color: #868686;
}

#skit_menu a, #skit_metamenu a {
  color: #868686;
  font-weight: bold;
  text-transform: lowercase;
}

#skit_menu li.selected a, #skit_metamenu li.selected a {
  color: #fff;
}

#skit_metamenu {
  font-size: 0.75em;
  margin-top: 2em;
  margin-bottom: 0.5em;
}

/* main content */
#skit_contentwrapper {
  background: #fff url(/images/x_default_sidebar_bg.gif) right top repeat-y;
}

#skit_content {
  padding: 10px 50px 10px 30px;
  background: url(<?cs var:chrome.href ?>/theme/images/content_top_bg.gif) repeat-x;
  font-size: 1.1em;
  color: #272727;
}

#skit_content em {
  color: #272727;
}

#skit_content a {
  color: #61ac00;
}

#skit_content h2 {
  font-size: 1.5em;
  color: #61ac00;
}

#skit_content pre {
  font-size: 1.2em;
  border: 2px solid #ccc;
  text-align: left;
}

/* footer */
#skit_footer {
  padding: 10px 30px;
  border-top: solid 1px #343434;
  background: #272727 url(<?cs var:chrome.href ?>/theme/images/footer_bg.gif) left bottom repeat-x;
  color: #bababa;
  font-size: 0.8em;
  text-align:center;
}

#skit_footer a {
  color: #bababa:
  text-decoration: underline;
}

#skit_footer a:hover {
  color: #eaeaea;
}

#subscribe a {
  font-weight: normal;
  font-size: 1.4em;
}
