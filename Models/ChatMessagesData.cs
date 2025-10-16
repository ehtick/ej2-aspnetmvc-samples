#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using Syncfusion.EJ2.InteractiveChat;

namespace EJ2MVCSampleBrowser.Models
{
    public class ChatMessagesData
    {
        public List<ChatUIMessage> GetUserChatMessages()
        {
            var UserChatMessagesUser1 = new UserModel
            {
                id = "user1",
                user = "Albert",
                avatarUrl = "./../Content/chatui/images/andrew.png"
            };

            var UserChatMessagesUser2 = new UserModel
            {
                id = "user2",
                user = "Reena",
                avatarUrl = "./../Content/chatui/images/reena.png"
            };

            List<ChatUIMessage> UserChatMessages = new List<ChatUIMessage>()
            {
                new ChatUIMessage() {
                    Text = "Hi there! How's it going?",
                    Author = UserChatMessagesUser1
                },
                new ChatUIMessage() { Text = "Hey! I'm doing well, thanks. How about you?", Author = UserChatMessagesUser2
                },
                new ChatUIMessage() { Text = "Mostly the usual stuff. I did start a new hobby - painting!", Author = UserChatMessagesUser1
                },
            };
            return UserChatMessages;
        }

        public List<ChatUIMessage> GetCommunityMessageData()
        {
            var CommunityMessageUser1 = new UserModel
            {
                id = "admin",
                user = "Alice Brown",
                statusIconCss = "e-icons e-user-busy"
            };

            var CommunityMessageUser2 = new UserModel
            {
                id = "user1",
                user = "Michale Suyama",
                avatarBgColor = "#87cefa",
                statusIconCss = "e-icons e-user-online"
            };

            var CommunityMessageUser3 = new UserModel
            {
                id = "user2",
                user = "Charlie",
                avatarUrl = "./../Content/chatui/images/charlie.png",
                avatarBgColor = "#e6cdde",
                statusIconCss = "e-icons e-user-away"
            };

            var CommunityMessageUser4 = new UserModel
            {
                id = "user3",
                user = "Janet",
                avatarUrl = "./../Content/chatui/images/janet.png",
                avatarBgColor = "#dec287",
                statusIconCss = "e-icons e-user-offline"
            };

            var GetCommunityMessageUser5 = new UserModel
            {
                id = "user4",
                user = "Jordan Peele",
                statusIconCss = "e-icons e-user-busy"
            };

            List<ChatUIMessage> CommunityMessages = new List<ChatUIMessage>()
            {
                new ChatUIMessage() {
                    Text = "Hey Michale, Charlie! Seen the latest posts in the Design Community? Amazing projects!",
                    Author = CommunityMessageUser1,
                    TimeStamp = new DateTime(2024, 10, 25, 23, 07, 30)
                },
                new ChatUIMessage() {
                    Text = "Hi Alice! Yes, Dana’s new UI design is incredible.",
                    Author = CommunityMessageUser2,
                    TimeStamp = new DateTime(2024, 10, 25, 8, 0, 0)
                },
                new ChatUIMessage() {
                    Text = "Hey! I loved Dana’s use of color. Frank’s typography guide was great too.",
                    Author = CommunityMessageUser3,
                    TimeStamp = new DateTime(2024, 10, 25, 11, 0, 0)
                },
                new ChatUIMessage() {
                    Text = "Dana’s work is so inspiring!",
                    Author = GetCommunityMessageUser5,
                    TimeStamp = new DateTime(2024, 10, 25, 11, 30, 0)
                },
                new ChatUIMessage() {
                    Text = "Absolutely! Any new community events planned?",
                    Author = CommunityMessageUser1,
                    TimeStamp = new DateTime(2024, 10, 26, 11, 0, 0)
                },
                new ChatUIMessage() {
                    Text = "We should organize a design challenge.",
                    Author = CommunityMessageUser2,
                    TimeStamp = new DateTime(2024, 10, 26, 12, 15, 0)
                },
                new ChatUIMessage() {
                    Text = "I am excited to see the new projects.",
                    Author = CommunityMessageUser4,
                    TimeStamp = new DateTime(2024, 10, 26, 12, 17, 0)
                },
                new ChatUIMessage() {
                    Text = "Great idea! Let’s discuss it in the next meeting.",
                    Author = CommunityMessageUser3,
                    TimeStamp = new DateTime(2024, 10, 26, 12, 30, 0)
                },
                new ChatUIMessage() {
                    Text = "Sounds good! This community is so inspiring.",
                    Author = CommunityMessageUser1,
                    TimeStamp = DateTime.Now
                },
                new ChatUIMessage() {
                    Text = "Agreed! Excited to see everyone’s ideas.",
                    Author = CommunityMessageUser2,
                    TimeStamp = DateTime.Now
                },
                new ChatUIMessage() {
                    Text = "I am looking forward to the design challenge.",
                    Author = CommunityMessageUser3,
                    TimeStamp = DateTime.Now
                }
            };

            return CommunityMessages;
        }

        public List<UserModel> GetMentionUsers()
        {
            return new List<UserModel>
            {
                new UserModel
                {
                    id = "admin",
                    user = "Alice Brown",
                    statusIconCss = "e-icons e-user-busy"
                },
                new UserModel
                {
                    id = "user1",
                    user = "Michale Suyama",
                    avatarBgColor = "#87cefa",
                    statusIconCss = "e-icons e-user-online"
                },
                new UserModel
                {
                    id = "user2",
                    user = "Charlie",
                    avatarUrl = "./../Content/chatui/images/charlie.png",
                    avatarBgColor = "#e6cdde",
                    statusIconCss = "e-icons e-user-away"
                },
                new UserModel
                {
                    id = "user3",
                    user = "Janet",
                    avatarUrl = "./../Content/chatui/images/janet.png",
                    avatarBgColor = "#dec287",
                    statusIconCss = "e-icons e-user-offline"
                },
                new UserModel
                {
                    id = "user4",
                    user = "Jordan Peele",
                    statusIconCss = "e-icons e-user-busy"
                }
            };
        }

        public class UserModel
        {
            public string id { get; set; }
            public string user { get; set; }
            public string avatarUrl { get; set; }
            public string avatarBgColor { get; set; }
            public string statusIconCss { get; set; }
        }
    }
}