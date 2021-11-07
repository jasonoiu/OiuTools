using Furion.DatabaseAccessor;

namespace OiuTools.Api.Core.Entity
{
    /// <summary>
    /// 写真集
    /// </summary>
    public class PhotoAlbums : EntityBase<long>
    {
        
        public long ModelId { get; set; }

        public string Url { get; set; }

        public string ThumbnailUrl { get; set; }



    }
}