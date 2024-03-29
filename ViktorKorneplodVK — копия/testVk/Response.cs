﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testVk
{
    class getProfileInfo
    {
        public Response response;
        public class Response
        {
            public string id;
            public string first_name;
            public string last_name;
            public string status_1223;
            public string name;
        }
    }
    class getAvatar
    {
        public Response[] response;
        public class Response
        {
            public string photo_50;
        }
    }


    public class FriendsGet
    {
        public Response response { get; set; }

        public class Item
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public bool can_access_closed { get; set; }
            public bool is_closed { get; set; }
            public string photo_50 { get; set; }
            public string track_code { get; set; }
            public List<int> lists { get; set; }
        }


        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }
//////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////

    }
        public class getInfoPosts
    {
        public class Item
        {
            public int id { get; set; }
            public string name { get; set; }
            public string screen_name { get; set; }
            public int is_closed { get; set; }
            public string type { get; set; }
            public string photo_50 { get; set; }
            public string photo_100 { get; set; }
            public string photo_200 { get; set; }
        }
        public class Response
        {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }

        public Response response { get; set; }
        }
    /// <summary>
    /// ////////////////////////////////////////////////////////////
    /// </summary>
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);


    public class WallPostsInfo
    {
    public class Size
    {
        public int height { get; set; }
        public string url { get; set; }
        public string type { get; set; }
        public int width { get; set; }
    }

    public class Photo
    {
        public int album_id { get; set; }
        public int date { get; set; }
        public int id { get; set; }
        public int owner_id { get; set; }
        public string access_key { get; set; }
        public int post_id { get; set; }
        public List<Size> sizes { get; set; }
        public string text { get; set; }
        public int user_id { get; set; }
        public bool has_tags { get; set; }
    }

    public class Attachment
    {
        public string type { get; set; }
        public Photo photo { get; set; }
    }

    public class PostSource
    {
        public string type { get; set; }
        public string platform { get; set; }
    }

    public class CopyHistory
    {
        public int id { get; set; }
        public int owner_id { get; set; }
        public int from_id { get; set; }
        public int date { get; set; }
        public string post_type { get; set; }
        public string text { get; set; }
        public List<Attachment> attachments { get; set; }
        public PostSource post_source { get; set; }
    }

    public class Comments
    {
        public int can_post { get; set; }
        public int count { get; set; }
        public bool groups_can_post { get; set; }
    }

    public class Likes
    {
        public int can_like { get; set; }
        public int count { get; set; }
        public int user_likes { get; set; }
        public int can_publish { get; set; }
    }

    public class Reposts
    {
        public int count { get; set; }
        public int user_reposted { get; set; }
    }

    public class Views
    {
        public int count { get; set; }
    }

    public class Donut
    {
        public bool is_donut { get; set; }
    }

    public class Item
    {
        public int id { get; set; }
        public int from_id { get; set; }
        public int owner_id { get; set; }
        public int date { get; set; }
        public bool is_favorite { get; set; }
        public string post_type { get; set; }
        public string text { get; set; }
        public List<CopyHistory> copy_history { get; set; }
        public PostSource post_source { get; set; }
        public Comments comments { get; set; }
        public Likes likes { get; set; }
        public Reposts reposts { get; set; }
        public Views views { get; set; }
        public Donut donut { get; set; }
        public double short_text_rate { get; set; }
        public string hash { get; set; }
    }

    public class Response
    {
        public int count { get; set; }
        public List<Item> items { get; set; }
    }



        public Response response { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);


    public class CreateComment
    {
    public class Response
    {
        public int comment_id { get; set; }
        public List<object> parents_stack { get; set; }
    }
        public Response response { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);


    public class GroupsSearch
    {
        public class Item
        {
        public int id { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public int is_closed { get; set; }
        public string type { get; set; }
        public string photo_50 { get; set; }
        public string photo_100 { get; set; }
        public string photo_200 { get; set; }
    }

    public class Response
    {
            public int count { get; set; }
            public List<Item> items { get; set; }
        }

        public Response response { get; set; }
    }



}
