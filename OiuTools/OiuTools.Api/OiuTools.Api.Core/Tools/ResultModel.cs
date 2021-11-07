namespace OiuTools.Api.Core.Tools
{
    /// <summary>
    /// 返回的结果
    /// </summary>
    public class ResultModel
    {
        public ResultModel() { }
        public ResultModel(ResultStatus status, string message = "", object data = null)
        {
            this.Message = message;
            this.Status = status;
            this.Data = data;
        }
        /// <summary>
        /// 返回结果的状态
        /// </summary>
        public ResultStatus Status { get; set; }
        /// <summary>
        /// 返回的提示信息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 要返回的数据
        /// </summary>
        public object Data { get; set; }
    }

    /// <summary>
    /// 状态枚举
    /// </summary>
    public enum ResultStatus
    {
        Success = 1,
        Error = -1
    }

}