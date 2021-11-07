using Furion.DatabaseAccessor;

namespace OiuTools.Api.Core.Entity
{
    public class BeautyModel: EntityBase<long>
    {
        public string Name { get; set; }
        /// <summary>
        /// 封面id
        /// </summary>
        public long CoverId { get; set; }
    }
}