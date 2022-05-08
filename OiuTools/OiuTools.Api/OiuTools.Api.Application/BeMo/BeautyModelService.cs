using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BlegMM;
using Furion;
using Furion.DatabaseAccessor;
using Furion.DatabaseAccessor.Extensions;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OiuTools.Api.Core.Entity;
using OiuTools.Api.Core.Tools;
using StaticExtend = OiuTools.Api.Core.Tools.StaticExtend;

namespace OiuTools.Api.Application.BeMo
{
    /// <summary>
    /// 模特服务接口
    /// </summary>
    public class BeautyModelService : IDynamicApiController, ITransient
    {
        //private readonly IRepository<BeautyModel> _modelRepository;
        //private readonly IRepository<PhotoAlbums> _albumsRepository;
        SystemSettings ss = SystemSettings.Singleton;

        //public BeautyModelService(IRepository<BeautyModel> modelRepository, IRepository<PhotoAlbums> albumsRepository)
        //{
        //    _modelRepository = modelRepository;
        //    _albumsRepository = albumsRepository;
        //}

        public BeautyModelService()
        {
            
        }

        /// <summary>
        /// 按页获取文件夹数据
        /// </summary>
        /// <param name="pageDto"></param>
        /// <returns></returns>
        public async Task<ResultModel> AllList(PageDto pageDto)
        {
            var list = ss.AllImgFolderObjList.FolderObjList
                .OrderByDescending(m => m.FolderNo)
                .Skip(pageDto.PageIndex * pageDto.PageSize)
                .Take(pageDto.PageSize)
                .ToList();
            return new ResultModel(ResultStatus.Success, "", list);
        }



        ///// <summary>
        ///// 上传图片
        ///// </summary>
        ///// <param name="file"></param>
        ///// <returns></returns>
        //[UnitOfWork]
        //public async Task<ResultModel> UploadPhoto(List<IFormFile> files)
        //{
        //    var req = App.HttpContext.Request;
        //    var model = new BeautyModel
        //    {
        //        Name = req.Form["name"].ToString(),
        //        Period = StaticExtend.ToInt(req.Form["period"])
        //    };
        //    if (files.IsNullOrEmpty() || StaticExtend.IsNullOrEmpty(model.Name) || model.Period == 0)
        //    {
        //        return new ResultModel(ResultStatus.Error, "参数错误！");
        //    }

        //    #region Save Photo

        //    var savePath = $@"c:\mm\{model.Name}_{model.Period}";
        //    if (!Directory.Exists(savePath))
        //    {
        //        Directory.CreateDirectory(savePath);
        //    }

        //    foreach (var file in files)
        //    {
        //        await using var stream = File.Create($@"{savePath}\{file.FileName}");
        //        await file.CopyToAsync(stream);
        //    }

        //    #endregion

        //    #region Save BeautyModel

        //    var singleModel = await _modelRepository.FirstOrDefaultAsync(m => m.Name == model.Name && m.Period == model.Period);
        //    if (singleModel==null)
        //    {
        //        var newModel = await _modelRepository.InsertNowAsync(model);
        //        singleModel = newModel.Entity;
        //    }

        //    var photoModel = new PhotoAlbums
        //    {
        //        ModelId = singleModel.Id,
        //        Url = $@"{savePath}\{files[0].FileName}", ThumbnailUrl = $@"{savePath}\{files[1].FileName}"
        //    };
        //    var photoResult = await _albumsRepository.InsertAsync(photoModel);


        //    #endregion



        //    return new ResultModel(ResultStatus.Success, "ok");
        //}
        



    }
}