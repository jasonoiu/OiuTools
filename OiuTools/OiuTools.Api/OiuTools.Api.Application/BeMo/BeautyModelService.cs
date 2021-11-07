using Furion.DatabaseAccessor;
using Furion.DynamicApiController;
using OiuTools.Api.Core.Entity;
using OiuTools.Api.Core.Tools;

namespace OiuTools.Api.Application.BeMo
{
    /// <summary>
    /// 模特服务接口
    /// </summary>
    public class BeautyModelService : IDynamicApiController
    {
        private readonly IRepository<BeautyModel> _modelRepository;
        private readonly IRepository<PhotoAlbums> _albumsRepository;


        public BeautyModelService(IRepository<BeautyModel> modelRepository, IRepository<PhotoAlbums> albumsRepository)
        {
            _modelRepository = modelRepository;
            _albumsRepository = albumsRepository;
        }


        public ResultModel UploadPhoto()
        {

        }



    }
}