﻿using System.Collections.Generic;
using Dialect.Model;

namespace Dialect.IRepository
{
    public interface IForumPostRepository
    {
        int Insert_ForumPost(ForumPost forumPost);

        IEnumerable<ForumPost> Get_ForumPosts();

        IEnumerable<ForumPost> Get_ForumPostsByForumId(int forumId);
    }
}
