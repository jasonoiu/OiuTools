using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Furion;
using Furion.DynamicApiController;
using Furion.RemoteRequest.Extensions;
using Microsoft.Extensions.Configuration;

namespace OiuTools.Api.Web.LocalEntry.Controllers
{
    
    public class BmController : IDynamicApiController
    {
        public IConfiguration Configuration { get; set; }

        [HttpGet]
        public string UploadPhoto([FromQuery] BmDto model)
        {
            if (model == null) return "参数错误";
            if (!File.Exists(model.Path)) return "文件不存在!";
            var bytes = File.ReadAllBytes(model.Path);
            var sbytes = File.ReadAllBytes(model.sPath);
            var fileName = Path.GetFileName(model.Path);
            var res = $@"{App.Configuration["ApiUrl"]}/api/beauty-model/upload-photo"
                .SetBody(new {name = model.Name, period = model.Period}, "multipart/form-data")
                .SetBodyBytes(("files", bytes, fileName), ("files", sbytes, "s_" + fileName)).PostAsStringAsync()
                .GetAwaiter().GetResult();
            return res;
        }




    }



    public class BmDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 期数
        /// </summary>
        public int Period { get; set; }
        /// <summary>
        /// 原图地址
        /// </summary>
        public string Path { get; set; }
        /// <summary>
        /// 缩略图地址
        /// </summary>
        public string sPath { get; set; }
    }



}
