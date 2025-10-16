#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers
{
    public partial class RichTextEditorController : Controller
    {
        public ActionResult ResizableEditor()
        {
            ViewData["Value"] = @"<p>
                        The Rich Text Editor component is WYSIWYG ('what you see is what you get') editor that provides the best user experience to create and update the content.
                        Users can format their content using standard toolbar commands.
                    </p>
                    <p><b> Key features:</b></p>
                    <ul>
                        <li><p> Provides &lt; IFRAME &gt; and &lt; DIV &gt; modes </p></li>
                        <li><p> Capable of handling markdown editing.</p></li>
                        <li><p> Contains a modular library to load the necessary functionality on demand.</p></li>
                        <li><p> Provides a fully customizable toolbar.</p></li>
                        <li><p> Provides HTML view to edit the source directly for developers.</p></li>
                        <li><p> Supports third - party library integration.</p></li>
                        <li><p> Allows preview of modified content before saving it.</p></li>
                        <li><p> Handles images, hyperlinks, video, hyperlinks, uploads, etc.</p></li>
                        <li><p> Contains undo / redo manager.</p></li>
                        <li><p> Creates bulleted and numbered lists.</p></li>
                    </ul>";
            return View();
        }
    }
}
