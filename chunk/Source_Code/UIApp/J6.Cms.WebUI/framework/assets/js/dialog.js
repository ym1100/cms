/* 此文件由系统自动生成! */
//
//文件：对话框插件
//版本: 1.0
//时间：2011-10-01
//
function simpleDialog(e) { this._simgpleDialog = true; this.window = window; this.win = window; this.doc = null; this.id = new Date().getMilliseconds() + parseInt(Math.random() * 100); this.title = e.title; this.usedrag = e.usedrag; this.style = e.style || 'ui-dialog'; this.setupFade = !e.setupFade ? e.setupFade : true; this.onclose = e.onclose; if (e.cross != false) { while (this.win.parent != this.win) { this.win = this.win.parent } } this.doc = this.win.document; this._inited = false; this.canvas = { width: this.doc.documentElement.clientWidth, height: Math.min(this.doc.documentElement.clientHeight, this.doc.body.clientHeight), maxHeight: Math.max(this.doc.documentElement.clientHeight, this.doc.body.clientHeight) }; this.point = { x: parseInt((this.canvas.width) / 2) + this.doc.documentElement.scrollLeft, y: parseInt((this.canvas.height) / 2) + this.doc.documentElement.scrollTop }; this.fixBoxPosition = function (a) { var b = this.getPanel().getElementsByTagName('DIV')[1]; if (!a) { this.point.x = (this.canvas.width - b.offsetWidth) / 2 + document.documentElement.scrollLeft; this.point.y = (this.canvas.height - b.offsetHeight) / 2 + document.documentElement.scrollTop; b.style.left = this.point.x + 'px'; b.style.top = this.point.y + 'px'; if (this.title && this.usedrag) { new drag(b.getElementsByTagName('div')[0], this.win).start(b) } } else { var c = this; var i = b.offsetWidth; var d = setInterval(function () { c.point.x = (c.canvas.width - b.offsetWidth) / 2 + document.documentElement.scrollLeft; c.point.y = (c.canvas.height - b.offsetHeight) / 2 + document.documentElement.scrollTop; b.style.left = c.point.x + 'px'; b.style.top = c.point.y + 'px'; if (i != b.offsetWidth) { clearInterval(d); if (c.title && c.usedrag) { new drag(b.getElementsByTagName('div')[0], c.win).start(b) } } }, 1) } } } simpleDialog.prototype._initialize = function () { if (this._inited) { return false } var a = this; var b = this.doc; var c = b.createElement('div'); c.id = 'panel_' + a.id; c.className = a.style; b.body.appendChild(c); var d = b.createElement('div'); d.className = 'bglayer'; d.style.cssText = 'z-index:999;position:absolute;top:0;left:0;width:' + a.canvas.width + 'px;height:' + a.canvas.maxHeight + 'px;'; c.appendChild(d); d = b.createElement("DIV"); d.className = 'box'; d.style.cssText = 'z-index:1000;position:absolute;left:' + (a.point.x) + "px;top:" + (a.point.y) + 'px;'; c.appendChild(d); if (a.title) { var e = b.createElement("div"); e.className = 'title'; e.innerHTML = '<span class="left corner" style="position:absolute;left:0;top:0">&nbsp;</span><span class="txt">' + a.title + '<span class="close" onclick="window[\'dialog_' + this.id + '\'].close()" style="position:absolute;right:5px;top:0;text-decoration:none;font-family:Verdana;cursor:pointer" title="关闭窗口"><span>X</span></span></span><span class="right corner" style="position:absolute;right:0;top:0">&nbsp;</span>'; d.appendChild(e); this.win['dialog_' + this.id] = this } var f = b.createElement("DIV"); f.className = 'content boxcontent'; f.id = 'boxcontent_' + this.id; d.appendChild(f); if (a.title) { var g = b.createElement("div"); g.className = 'bottom'; g.style.cssText = "position:relative;"; g.innerHTML = '<span class="left corner" style="position:absolute;left:0;top:0">&nbsp;</span><span class="txt">&nbsp;</span><span class="right corner" style="position:absolute;right:0;top:0">&nbsp;</span>'; d.appendChild(g) } this._inited = true }; simpleDialog.prototype.getPanel = function () { return this.doc.getElementById('panel_' + this.id) }; simpleDialog.prototype.async = function (a, b, c, d, e) { this._initialize(); var f = this.doc.getElementById('boxcontent_' + this.id); if (d) { d(f) } var g = j6.xhr; var h = this; if (!b || b.toLowerCase() == "get") { g.get(a, function (x) { j6.loadHTML(f, x); h.fixBoxPosition(true); if (e) e(x) }) } else { g.post(a, c, function (x) { j6.loadHTML(f, x); h.fixBoxPosition(true); if (e) e(x) }) } }; simpleDialog.prototype.open = function (a, b, c, d) { this._initialize(); var e = this.doc.getElementById('boxcontent_' + this.id); e.innerHTML += "<iframe frameborder='0' scrolling='" + (d || 'no') + "' src='" + a + "' width='" + (b || '100%') + "' style='padding:0' height='" + (c || '100%') + "'></iframe>"; e.style.width = Math.max(e.scrollWidth, b) + 'px'; e.style.height = Math.max(e.scrollHeight, c) + 'px'; this.fixBoxPosition() }; simpleDialog.prototype.write = function (a) { this._initialize(); var b = this.doc.getElementById('boxcontent_' + this.id); if (!this.title) { b.innerHTML = a } else { var c = b.getElementsByTagName('DIV'); for (var i = 1; i < c.length; i++) { b.removeChild(c[i]) } b.innerHTML += a } this.fixBoxPosition() }; simpleDialog.prototype.getFrameWindow = function () { var a = this.getPanel().getElementsByTagName('IFRAME'); if (a.length > 0) { return a[0].contentWindow } return null }; simpleDialog.prototype.close = function (b) { if (this.onclose != null && this.onclose() == false) { return false } var c = 0; var d = this.getPanel(); var e = (function (a) { return function () { a.document.body.removeChild(d); if (b) b() } }(this.win)); try { delete this.win['dialog_' + this.id] } catch (ex) { this.win['dialog_' + this.id] = null } e(); this._inited = false }; function drag(a, b) { this.elem = a; this.win = b } drag.prototype.regist = function (a, b, c, d) { var o = this.elem; a = a ? a : o; var f, sy; var g = this.win == null ? g : this.win.document; o.style.cursor = b || "move"; var h = c || function (e) { e = e || event; window.getSelection ? window.getSelection().removeAllRanges() : g.selection.empty(); if (e.preventDefault) e.preventDefault(); with (a.style) { position = "absolute"; left = e.clientX - f + "px"; top = e.clientY - sy + "px" } }; j6.event.add(o, "mousedown", function (e) { e = e || event; if (e.button == 1 || e.button == 0) { f = e.clientX - a.offsetLeft; sy = e.clientY - a.offsetTop; j6.event.add(g, 'mousemove', h, false); j6.event.add(g, 'mouseup', i, false) } }, false); var i = function () { j6.event.remove(g, 'mousemove', h, false); j6.event.remove(g, 'mouseup', i, false); if (d && d instanceof Function) d() } }; drag.prototype.custom = function (a, b, c, d) { return this.regist(a, b, c, d) }; drag.prototype.start = function (a) { this.regist(a, null, null, null) }; var SimpleDialog = { create: function (a) { return new simpleDialog(a) }, create2: function (a, b, c, d, e) { return new simpleDialog({ title: a, usedrag: b || false, cross: c || false, style: e, onclose: d }) }, getDialog: function () { var b = null; var c = /^dialog_/i; var e = window; var f = function (a) { var d = null; for (var i in a) { if (c.test(i) && a[i] != null) { d = a[i]; break } } return d }; do { b = f(e); if (b == null) { e = e.parent; b = f(e) } if (b) { break } } while (e.parent != e); return b }, close: function () { var d = this.getDialog(); if (d) d.close() } }; (function (j) { j.extend({ dialog: window.SimpleDialog, drag: function (a, b) { return new drag(a, b) } }) }(j6));