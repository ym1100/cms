﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.34209
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace J6.Cms.Web.Resource {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SiteResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SiteResource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("J6.Cms.Web.Resource.SiteResource", typeof(SiteResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 // ***********************************************
        ///// J6.Cms.NET Js Libaray  v4.5
        ///// 发布日期：2014-06-01 18:20
        ///// ***********************************************
        ///// 加载示例
        /////    global.js?hover=navi,clist,alist&amp;ld=：
        /////    对导航,栏目导航和文档导航设置样式为&quot;current&quot;
        /////
        ///function j6l() { this.__VERSION__ = &apos;3.1&apos;; this.__WORKPATH__ = &apos;&apos;; this.__Extend_PROTOTYPE__ = true } j6l.prototype = { __init__: function () { if (this.__Extend_PROTOTYPE__) { this.__extendingJsPrototype__() } var f = document.getElementsByTagName(&apos;SCRIPT&apos; [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string cms_core_min {
            get {
                return ResourceManager.GetString("cms_core_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //
        /////文件：Cms Javascript WebApi
        /////版本: 0.0.1
        /////时间：2014-06-21
        ///// Note : 请调用API前，先调用j6.api.setPath(&apos;${page.domain}&apos;);这样才能请求到指定站点的接口。
        ///// Modify :  2015-09-18 19:37  [jsix] [!] : 重构
        /////
        ///if (!window.j6) alert(&apos;未加载core.js！&apos;);
        ///j6.extend({
        ///    api: {
        ///        path: &apos;&apos;,
        ///        setPath:function(p) {
        ///            this.path = p;
        ///        },
        ///        request: function (apiName, params, call, errCall) {
        ///            var uri = this.path + &apos;/webapi?key=11857832134&amp;name=&apos; + apiName;
        ///            for (var key in param [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_cms_api {
            get {
                return ResourceManager.GetString("js_cms_api", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //
        /////文件：动画插件
        /////版本: 1.0
        /////时间：2014-11-06
        /////
        ///j6.extend({ animation: { timer: function (a, b, c, d, e) { if (!a) return; var f = c != null ? c : 0; var g = d != null ? d : 100; var h = 0; var i = 0; if (e &lt; 1 || e &gt; 5) { h = (d - c) &lt; 0 ? -e : e; i = 20 } else { h = (g - f) / (4 * (6 - e)); h *= (Math.abs(g - f) / 100); i = 1000 / h; i = i &lt; 0 ? -Math.ceil(i) : Math.floor(i); if (i &lt; 30) i = 30 } var t = setInterval(function () { f = f + h; if (Math.abs(f) &gt;= Math.abs(g)) { f = g; if (b instanceof Function [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_lib_animation {
            get {
                return ResourceManager.GetString("js_lib_animation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //
        /////文件：数据表格插件
        /////版本: 1.0
        /////时间：2011-10-01
        /////
        ///function datagrid(h, k) { this.panel = h.nodeName ? h : j6.$(h); this.columns = k.columns; this.idField = k.idField || &quot;id&quot;; this.data_url = k.url; this.data = k.data; this.onLoaded = k.loaded; this.loadbox = null; this.gridView = null; this.loading = function () { if (this.gridView.offsetHeight == 0) { var a = this.gridView.previousSibling.offsetHeight; var b = this.panel.offsetHeight - this.gridView.previousSibling.offsetHeight; this.gridView.style.cssText  [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_lib_datagrid {
            get {
                return ResourceManager.GetString("js_lib_datagrid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //
        /////文件：对话框插件
        /////版本: 1.0
        /////时间：2011-10-01
        /////
        ///function simpleDialog(e) { this._simgpleDialog = true; this.window = window; this.win = window; this.doc = null; this.id = new Date().getMilliseconds() + parseInt(Math.random() * 100); this.title = e.title; this.usedrag = e.drag; this.style = e.style || &apos;ui-dialog&apos;; this.setupFade = !e.setupFade ? e.setupFade : true; this.onclose = e.onclose; this.canNotClose = e.canClose == false; if (e.cross != false) { while (this.win.parent != this.win) { this.win = this.w [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_lib_dialog {
            get {
                return ResourceManager.GetString("js_lib_dialog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 /*
        ///* file：表单及验证插件
        ///* version : 1.0
        ///* date：2011-10-01
        ///* history :
        ///*  2014-12-07 18:57 [!] : 修改验证器
        ///*/
        ///j6.extend({ form: { getData: function (a) { var b = &apos;&apos;; var c = document.forms[a || 0]; return j6.json.toQueryString(c) }, asyncSubmit: function (a, b) { var c = document.forms[a || 0]; var d = document.getElementById(&apos;$async_ifr&apos;); if (!d) { try { d = document.createElement(&apos;&lt;iframe name=&quot;$async_ifr&quot;&gt;&apos;) } catch (ex) { d = document.createElement(&apos;iframe&apos;); d.setAttribute(&apos;name&apos;, &apos;$async_ifr&apos;) } d.setAtt [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_lib_form {
            get {
                return ResourceManager.GetString("js_lib_form", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //
        /////文件：卷轴插件
        /////版本: 1.0
        /////时间：2011-10-01
        /////
        ///
        ///j6.extend({ roller: { init: function (a) { this.elem = a.elem; this.direction = a.direction; this.pix = a.pix; this.elem.style.cssText += &apos;overflow:hidden;&apos; }, start: function (a, b) { var c = this.elem, _pix = this.pix, a = a | 1; var i, j; var d; var e = function () { if (b != null) b() }; switch (this.direction) { case &quot;up&quot;: i = _pix; j = 0; d = setInterval(function () { i -= a; if (i &lt; 0) { i = 0; clearInterval(d); e() } c.style.height = i.toString() + &quot;p [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_lib_roller {
            get {
                return ResourceManager.GetString("js_lib_roller", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //
        /////文件：滚动条插件
        /////版本: 1.0
        /////时间：2011-10-01
        /////
        ///var JS_scrollbar = { $: window.j6, pnode: null, ele: null, startP: { x: 0, y: 0 }, moveP: { x: 0, y: 0, z: -1 }, slideBar: null, init: function (e) { this.ele = e.nodeName ? e : document.getElementById(e); this.pnode = document.createElement(&apos;DIV&apos;); this.slideBar = null; this.timer = null; var a = this.ele.parentNode; a.insertBefore(this.pnode, this.ele); this.pnode.appendChild(this.ele); this.pnode.className = &apos;scrollbar&apos;; this.pnode.style.cssText += &apos;height: [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_lib_scrollbar {
            get {
                return ResourceManager.GetString("js_lib_scrollbar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //
        /////文件：滚动效果插件
        /////版本: 1.0
        /////时间：2011-10-01
        /////
        ///
        ///function scroller(b, c, d) { this.$P = null; this.$C = null; this.$L = null; this.pagePanel = null; this.index = 0; this.offset = 0; this.scroll = 0; this.scrollUnit = c.unit || 5; this.lock = false; this.direction = c.direction || &apos;left&apos;; this.interval = d; this.timer = null; this.taskTimer = null; this.$P = document.getElementById(b); this.$P.style.cssText += &apos;overflow:hidden;position:relative;&apos;; var f = this.$P.getElementsByTagName(&apos;UL&apos;); if (f.length == [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_lib_scroller {
            get {
                return ResourceManager.GetString("js_lib_scroller", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //
        /////名称 ： Table库
        /////版本:1.0
        /////时间：2012-09-22
        /////
        ///j6.extend({ table: { dynamic: function (f, g, h) { if (f &amp;&amp; f.nodeName === &quot;TABLE&quot;) { f.className += &apos; ui-table&apos;; var j = f.getElementsByTagName(&apos;TH&apos;); window.j6.each(j, function (i, e) { if (i != j.length - 1) { if ((e.getElementsByClassName ? e.getElementsByClassName(&apos;th-split&apos;) : document.getElementsByClassName(&apos;th-split&apos;, e)).length == 0) { var a = document.createElement(&quot;SPAN&quot;); a.className = &apos;th-split&apos;; e.appendChild(a) } } }); var k = f.getElementsByT [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_lib_table {
            get {
                return ResourceManager.GetString("js_lib_table", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //
        /////文件：UI基础库(ui,validate,form,table,scrollbar,form)
        /////版本: 1.0
        /////时间：2011-10-01
        /////
        ///
        ///function HS_DateAdd(a, b, c) { b = parseInt(b); if (typeof (c) == &quot;string&quot;) { var c = new Date(c.split(&quot;-&quot;)[0], c.split(&quot;-&quot;)[1], c.split(&quot;-&quot;)[2]) } if (typeof (c) == &quot;object&quot;) { var c = c } switch (a) { case &quot;y&quot;: return new Date(c.getFullYear() + b, c.getMonth(), c.getDate()); break; case &quot;m&quot;: return new Date(c.getFullYear(), c.getMonth() + b, checkDate(c.getFullYear(), c.getMonth() + b, c.getDate())); break; case &quot;d&quot;:  [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_lib_ui {
            get {
                return ResourceManager.GetString("js_lib_ui", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 //
        /////文件：上传插件
        /////版本: 1.0
        /////时间：2013-10-01
        /////
        ///function fileUpload(h, i) { this.id = h.id; this.infopanel = h.info ? document.getElementById(h.info) : null; this.processID = Math.random() * 100 + 100; this.debug = h.debug || false; this.uploadurl = h.url, this.processurl = h.processurl, this.filename = null; this.file = null; this.repeatSelect = h.repeatSelect == undefined ? false : h.repeatSelect; this.btnText = &apos;&apos;; this.btnClicked = false; this.repeatSelect = false; var j = document.getElementById(this.id [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_lib_upload {
            get {
                return ResourceManager.GetString("js_lib_upload", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 eval(function (p, a, c, k, e, r) { e = function (c) { return (c &lt; a ? &apos;&apos; : e(parseInt(c / a))) + ((c = c % a) &gt; 35 ? String.fromCharCode(c + 29) : c.toString(36)) }; if (!&apos;&apos;.replace(/^/, String)) { while (c--) r[e(c)] = k[c] || e(c); k = [function (e) { return r[e] }]; e = function () { return &apos;\\w+&apos; }; c = 1 }; while (c--) if (k[c]) p = p.replace(new RegExp(&apos;\\b&apos; + e(c) + &apos;\\b&apos;, &apos;g&apos;), k[c]); return p }(&apos;u 3c(a,b,c){b=1C(b);r(2J(c)==&quot;4z&quot;){8 c=19 1Q(c.22(&quot;-&quot;)[0],c.22(&quot;-&quot;)[1],c.22(&quot;-&quot;)[2])}r(2J(c)==&quot;4A&quot;){8 c= [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string js_ui_min {
            get {
                return ResourceManager.GetString("js_ui_min", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 body{font:62.5%/1.5 Sans-Serif,Arial;margin:0;}
        ///img{border:none;max-width: 100%;}
        ///a{outline:none;}
        ///table{border-collapse:collapse;border:none;}
        ///a:link,a:visited{color:#0066ff;}
        ///a:hover{color:#0000cc;}
        ///.mask{background:url(/framework/assets/images/mask.gif);opacity:0.2;alpha(opacity=20);position:absolute;top:0;left:0;bottom: 0;right: 0;}
        ///p,td,blockquote,pre{ word-break: break-all;word-wrap: break-word;}
        ///
        ///
        ////* +++++++++++++ Classes ++++++++++++++ */
        ///
        ///.left{float:left;}
        ///.right{float:right;}
        ///.cente [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string template {
            get {
                return ResourceManager.GetString("template", resourceCulture);
            }
        }
    }
}
