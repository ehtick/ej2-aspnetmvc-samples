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
using System.Web;

namespace EJ2MVCSampleBrowser.Models
{
    public class SocialMedia
    {
        public string Class { get; set; }
        public string SocialMediaName { get; set; }
        public string Id { get; set; }
        public List<SocialMedia> SocialMediaList()
        {
            List<SocialMedia> media = new List<SocialMedia>();
            media.Add(new SocialMedia{ Class= "facebook", SocialMediaName= "Facebook", Id= "media1" });
            media.Add(new SocialMedia{ Class= "google-plus", SocialMediaName= "Google Plus", Id= "media2" });
            media.Add(new SocialMedia{ Class= "instagram", SocialMediaName= "Instagram", Id= "media3" });
            media.Add(new SocialMedia{ Class= "linkedin", SocialMediaName= "LinkedIn", Id= "media4" });
            media.Add(new SocialMedia{ Class= "skype", SocialMediaName= "Skype", Id= "media5" });
            media.Add(new SocialMedia{ Class= "tumblr", SocialMediaName= "Tumblr", Id= "media6" });
            media.Add(new SocialMedia{ Class= "twitter", SocialMediaName= "Twitter", Id= "media7" });
            media.Add(new SocialMedia{ Class= "vimeo", SocialMediaName= "Vimeo", Id= "media8" });
            media.Add(new SocialMedia{ Class= "whatsapp", SocialMediaName= "WhatsApp", Id= "media9" });
            media.Add(new SocialMedia { Class = "youtube", SocialMediaName= "YouTube", Id = "media10" });
            return media;
        }
    }
}
