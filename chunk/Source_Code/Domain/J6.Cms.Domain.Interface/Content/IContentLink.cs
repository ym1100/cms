﻿using J6.Cms.Domain.Interface.Common;

namespace J6.Cms.Domain.Interface.Content
{
    /// <summary>
    /// 
    /// </summary>
    public interface IContentLink:ILink
    {
        /// <summary>
        /// 内容编号
        /// </summary>
        int ContentId { get; set; }
    }
}
